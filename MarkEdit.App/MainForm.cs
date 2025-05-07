using MarkEdit.App.Events;
using MarkEdit.Commands.Basic;
using MarkEdit.Commands.Clipboard;
using MarkEdit.Commands.Formatting;
using MarkEdit.Commands.Formatting.Prefixing;
using MarkEdit.Commands.Formatting.Wrapping;
using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.App;

public partial class MainForm : Form
{
    private readonly CommandManager _commandManager;
    private readonly ITextEditor _editor;
    private readonly IClipboard _clipboard;

    public MainForm()
    {
        InitializeComponent();

        _editor = new TextBoxAdapter(textBox1);
        _commandManager = new CommandManager(200);
        _clipboard = new ClipboardAdapter();

        textBox1.CharacterInserted += OnCharacterInsert;
        textBox1.CharacterDeleted += OnCharacterDelete;
        textBox1.TextChanged += OnTextChanged;

        cutToolStripButton.Click += (_, _) => _commandManager.Execute(new CutCommand(_editor, _clipboard));
        copyToolStripButton.Click += (_, _) => _commandManager.Execute(new CopyCommand(_editor, _clipboard));
        pasteToolStripMenuItem.Click += (_, _) => _commandManager.Execute(new PasteCommand(_editor, _clipboard));
        undoToolStripButton.Click += (_, _) => _commandManager.Undo();
        redoToolStripButton.Click += (_, _) => _commandManager.Redo();
        boldToolStripButton.Click += (_, _) => _commandManager.Execute(new BoldCommand(_editor));
        italicToolStripButton.Click += (_, _) => _commandManager.Execute(new ItalicCommand(_editor));
        quoteToolStripButton.Click += (_, _) => _commandManager.Execute(new QuoteCommand(_editor));
        codeToolStripButton.Click += (_, _) => _commandManager.Execute(new CodeCommand(_editor));
        
        foreach (var level in Enumerable.Range(1, 6))
        {
            headerToolStripDropDown.DropDownItems.Add(
                $"Header {level}", 
                null,
                (_, _) => _commandManager.Execute(new HeaderCommand(_editor, level)));
        }

        cutToolStripMenuItem.Click += (_, _) => _commandManager.Execute(new CutCommand(_editor, _clipboard));
        copyToolStripMenuItem.Click += (_, _) => _commandManager.Execute(new CopyCommand(_editor, _clipboard));
        pasteToolStripMenuItem.Click += (_, _) => _commandManager.Execute(new PasteCommand(_editor, _clipboard));
        undoToolStripMenuItem.Click += (_, _) => _commandManager.Undo();
        redoToolStripMenuItem.Click += (_, _) => _commandManager.Redo();
    }

    private void OnTextChanged(object? sender, EventArgs e)
    {
        var index = textBox1.SelectionStart;
        var line = textBox1.GetLineFromCharIndex(index);
        var column = index - textBox1.GetFirstCharIndexOfCurrentLine();
        
        toolStripStatusLabel.Text = $"Ln {line + 1}, Col {column + 1}";
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
