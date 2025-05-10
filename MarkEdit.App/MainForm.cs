using MarkEdit.App.Events;
using MarkEdit.Commands;
using MarkEdit.Commands.Basic;
using MarkEdit.Commands.Clipboard;
using MarkEdit.Commands.File;
using MarkEdit.Commands.Formatting.Prefixing;
using MarkEdit.Commands.Formatting.Wrapping;
using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.App;

public partial class MainForm : Form
{
    private CommandManager _commandManager;
    private ITextEditor _editor;
    private IClipboard _clipboard;
    private Document _document;
    private IFileService _fileService;
    private ILinkProvider _linkProvider;

    public MainForm()
    {
        InitializeComponent();
        InitializeServices();
        RegisterTextEditorEvents();
        WireUpQuickAccessCommands();
        WireUpMenuStripCommands();
    }
    
    private void InitializeServices()
    {
        _editor = new TextBoxAdapter(textBox1);
        _commandManager = new CommandManager(200);
        _clipboard = new ClipboardAdapter();
        _document = new Document();
        _fileService = new FileService();
        _linkProvider = new LinkPromptProvider();
    }
    
    private void RegisterTextEditorEvents()
    {
        textBox1.CharacterInserted += OnCharacterInsert;
        textBox1.CharacterDeleted += OnCharacterDelete;
        textBox1.TextChanged += OnTextChanged;
    }

    private void WireUpQuickAccessCommands()
    {
        //File commands
        BindClick(newQuickAccessButton, () => new NewCommand(_document, _editor));
        BindClick(openQuickAccessButton, () => new OpenCommand(_document, _fileService, _editor));
        BindClick(saveQuickAccessButton, () => new SaveCommand(_document, _fileService, _editor));
        BindClick(saveAsQuickAccessButton, () => new SaveAsCommand(_document, _fileService, _editor));
        //Clipboard commands
        BindClick(cutQuickAccessButton, () => new CutCommand(_editor, _clipboard));
        BindClick(copyQuickAccessButton, () => new CopyCommand(_editor, _clipboard));
        BindClick(pasteQuickAccessButton, () => new PasteCommand(_editor, _clipboard));
        //History commands
        BindClick(undoQuickAccessButton, _commandManager.Undo);
        BindClick(redoQuickAccessButton, _commandManager.Redo);
        //Formatting commands
        BindClick(boldQuickAccessButton, () => new BoldCommand(_editor));
        BindClick(italicQuickAccessButton, () => new ItalicCommand(_editor));
        BindClick(quoteQuickAccessButton, () => new QuoteCommand(_editor));
        BindClick(codeQuickAccessButton, () => new CodeCommand(_editor));
        BindClick(h1QuickAccessItem, () => new HeaderCommand(_editor, 1));
        BindClick(h2QuickAccessItem, () => new HeaderCommand(_editor, 2));
        BindClick(h3QuickAccessItem, () => new HeaderCommand(_editor, 3));
        BindClick(h4QuickAccessItem, () => new HeaderCommand(_editor, 4));
        BindClick(h5QuickAccessItem, () => new HeaderCommand(_editor, 5));
        BindClick(h6QuickAccessItem, () => new HeaderCommand(_editor, 6));
        BindClick(linkToolStripButton, () => new LinkCommand(_editor, _linkProvider));
    }

    private void WireUpMenuStripCommands()
    {
        // File commands
        BindClick(newToolStripMenuItem, () => new NewCommand(_document, _editor));
        BindClick(openToolStripMenuItem, () => new OpenCommand(_document, _fileService, _editor));
        BindClick(saveToolStripMenuItem, () => new SaveCommand(_document, _fileService, _editor));
        BindClick(saveAsToolStripMenuItem, () => new SaveAsCommand(_document, _fileService, _editor));
        BindClick(exitToolStripMenuItem, Application.Exit);
        // Clipboard commands
        BindClick(cutToolStripMenuItem, () => new CutCommand(_editor, _clipboard));
        BindClick(copyToolStripMenuItem, () => new CopyCommand(_editor, _clipboard));
        BindClick(pasteToolStripMenuItem, () => new PasteCommand(_editor, _clipboard));
        // History commands
        BindClick(undoToolStripMenuItem, _commandManager.Undo);
        BindClick(redoToolStripMenuItem, _commandManager.Redo);
        // Formatting commands
        BindClick(boldToolStripMenuItem, () => new BoldCommand(_editor));
        BindClick(italicToolStripMenuItem, () => new ItalicCommand(_editor));
        BindClick(h1ToolStripMenuItem, () => new HeaderCommand(_editor, 1));
        BindClick(h2ToolStripMenuItem, () => new HeaderCommand(_editor, 2));
        BindClick(h3ToolStripMenuItem, () => new HeaderCommand(_editor, 3));
        BindClick(h4ToolStripMenuItem, () => new HeaderCommand(_editor, 4));
        BindClick(h5ToolStripMenuItem, () => new HeaderCommand(_editor, 5));
        BindClick(h6ToolStripMenuItem, () => new HeaderCommand(_editor, 6));
    }
    
    private void BindClick(ToolStripItem item, Func<ICommand> commandFactory)
    {
        item.Click += (_, _) => _commandManager.Execute(commandFactory());
    }

    private void BindClick(ToolStripItem item, Action action)
    {
        item.Click += (_, _) => action();
    }

    private void OnTextChanged(object? sender, EventArgs e)
    {
        var index = textBox1.SelectionStart;
        var line = textBox1.GetLineFromCharIndex(index);
        var column = index - textBox1.GetFirstCharIndexOfCurrentLine();

        toolStripStatusLabel.Text = $"Ln {line + 1}, Col {column + 1}";

        _document.Content = _editor.Text;
        _document.IsDirty = true;
    }

    private void OnCharacterInsert(object? sender, CharChangeEventArgs e)
    {
        if (!_commandManager.InternalChange)
        {
            _commandManager.Save(new InsertCommand(_editor, e.Position, e.Character));
        }
    }

    private void OnCharacterDelete(object? sender, CharChangeEventArgs e)
    {
        if (!_commandManager.InternalChange)
        {
            _commandManager.Save(new DeleteCommand(_editor, e.Position, e.Character));
        }
    }
}
