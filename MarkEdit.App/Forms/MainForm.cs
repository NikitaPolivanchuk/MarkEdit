using Markdig;
using MarkEdit.App.Adapters;
using MarkEdit.App.Events;
using MarkEdit.App.Services;
using MarkEdit.App.ViewStates;
using MarkEdit.Commands;
using MarkEdit.Commands.Basic;
using MarkEdit.Commands.Clipboard;
using MarkEdit.Commands.File;
using MarkEdit.Commands.Formatting.Prefixing;
using MarkEdit.Commands.Formatting.Wrapping;
using MarkEdit.Commands.List;
using MarkEdit.Core;
using MarkEdit.Core.Commands;
using Microsoft.Web.WebView2.Core;

namespace MarkEdit.App.Forms;

public partial class MainForm : Form
{
    private CommandManager _commandManager;
    private ITextEditor _editor;
    private IClipboard _clipboard;
    private Document _document;
    private IFileService _fileService;
    private ILinkProvider _linkProvider;
    private ListContinuationHelper _listContinuation;
    private IViewState _currentViewState;

    public SplitContainer SplitContainer => splitContainer;

    public MainForm()
    {
        InitializeComponent();
        InitializeWebView();
        InitializeServices();
        RegisterTextEditorEvents();
        WireUpMenuStripCommands();
        WireUpQuickAccessCommands();
        WireUpContextMenuCommands();
        WireUpViewMenuCommands();
    }
    
    private void InitializeServices()
    {
        _editor = new TextBoxAdapter(textBox);
        _commandManager = new CommandManager(200);
        _clipboard = new ClipboardAdapter();
        _document = new Document();
        _fileService = new FileService();
        _linkProvider = new LinkPromptProvider();
        _listContinuation = new ListContinuationHelper();
    }
    
    private void InitializeWebView()
    {
        webView.CoreWebView2InitializationCompleted += (_, e) =>
        {
            if (e.IsSuccess)
            {
                webView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
            }
        };

        _ = webView.EnsureCoreWebView2Async(null);
    }
    
    private void RegisterTextEditorEvents()
    {
        textBox.CharacterInserted += OnCharacterInsert;
        textBox.TextDeleted += OnTextDelete;
        textBox.TextChanged += OnTextChanged;
    }
    
    private void WireUpMenuStripCommands()
    {
        //File commands
        BindClick(newToolStripMenuItem, () => new NewCommand(_document, _editor));
        BindClick(openToolStripMenuItem, () => new OpenCommand(_document, _fileService, _editor));
        BindClick(saveToolStripMenuItem, () => new SaveCommand(_document, _fileService, _editor));
        BindClick(saveAsToolStripMenuItem, () => new SaveAsCommand(_document, _fileService, _editor));
        BindClick(exitToolStripMenuItem, Application.Exit);
        //Clipboard commands
        BindClick(cutToolStripMenuItem, () => new CutCommand(_editor, _clipboard));
        BindClick(copyToolStripMenuItem, () => new CopyCommand(_editor, _clipboard));
        BindClick(pasteToolStripMenuItem, () => new PasteCommand(_editor, _clipboard));
        //History commands
        BindClick(undoToolStripMenuItem, _commandManager.Undo);
        BindClick(redoToolStripMenuItem, _commandManager.Redo);
        //Formatting commands
        BindClick(boldToolStripMenuItem, () => new BoldCommand(_editor));
        BindClick(italicToolStripMenuItem, () => new ItalicCommand(_editor));
        BindClick(h1ToolStripMenuItem, () => new HeaderCommand(_editor, 1));
        BindClick(h2ToolStripMenuItem, () => new HeaderCommand(_editor, 2));
        BindClick(h3ToolStripMenuItem, () => new HeaderCommand(_editor, 3));
        BindClick(h4ToolStripMenuItem, () => new HeaderCommand(_editor, 4));
        BindClick(h5ToolStripMenuItem, () => new HeaderCommand(_editor, 5));
        BindClick(h6ToolStripMenuItem, () => new HeaderCommand(_editor, 6));
        //Link command
        BindClick(linkToolStripMenuItem, () => new LinkCommand(_editor, _linkProvider));
        //List commands
        BindClick(bulletListToolStripMenuItem, () => new BulletListCommand(_editor));
        BindClick(numberedListToolStripMenuItem, () => new NumberedListCommand(_editor));
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
        //Link command
        BindClick(linkQuickAccessButton, () => new LinkCommand(_editor, _linkProvider));
        //List commands
        BindClick(bulletListQuickAccessButton, () => new BulletListCommand(_editor));
        BindClick(numberedListQuickAccessButton, () => new NumberedListCommand(_editor));
    }

    private void WireUpContextMenuCommands()
    {
        textBox.ContextMenuStrip = contextMenuStrip;
        
        //History commands
        BindClick(undoContextMenuItem, _commandManager.Undo);
        BindClick(redoContextMenuItem, _commandManager.Redo);
        //Clipboard commands
        BindClick(cutContextMenuItem, () => new CutCommand(_editor, _clipboard));
        BindClick(copyContextMenuItem, () => new CopyCommand(_editor, _clipboard));
        BindClick(pasteContextMenuItem, () => new PasteCommand(_editor, _clipboard));
        //Formatting commands
        BindClick(boldContextMenuItem, () => new BoldCommand(_editor));
        BindClick(italicContextMenuItem, () => new ItalicCommand(_editor));
        BindClick(codeContextMenuItem, () => new CodeCommand(_editor));
        //Link command
        BindClick(linkContextMenuItem, () => new LinkCommand(_editor, _linkProvider));
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
        var index = textBox.SelectionStart;
        var line = textBox.GetLineFromCharIndex(index);
        var column = index - textBox.GetFirstCharIndexOfCurrentLine();
        
        toolStripStatusLabel.Text = $"Ln {line + 1}, Col {column + 1}";

        _document.Content = _editor.Text;
        _document.IsDirty = true;

        UpdatePreview(_editor.Text);
    }

    private void OnCharacterInsert(object? sender, CharChangeEventArgs e)
    {
        if (_commandManager.InternalChange)
        {
            return;
        }
        
        if (e.Character == '\n' || e.Character == '\r')
        {
            var command = _listContinuation.GetContinuationCommand(_editor);
            if (command != null)
            {
                _commandManager.Execute(command);
                e.Handled = true;
                return;
            }
        }
        
        _commandManager.Save(new InsertCommand(_editor, e.Position, e.Character));
    }

    private void OnTextDelete(object? sender, TextDeletedEventArgs e)
    {
        if (!_commandManager.InternalChange)
        {
            _commandManager.Save(new DeleteCommand(_editor, e.Position, e.DeletedText));
        }
    }
    
    private void UpdatePreview(string content)
    {
        var html = Markdown.ToHtml(content);
        webView.CoreWebView2.NavigateToString($"<html><body>{html}</body></html>");
    }
    
    private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e)
    {
        if (e.IsUserInitiated)
        {
            e.Cancel = true;
        }
    }
    
    private void WireUpViewMenuCommands()
    {
        SetViewState(new SplitViewState());

        BindClick(togglePreviewToolStripMenuItem, () => SetViewState(new PreviewOnlyState()));
        BindClick(toggleSourceViewToolStripMenuItem, () => SetViewState(new SourceOnlyState()));
        BindClick(splitViewToolStripMenuItem, () => SetViewState(new SplitViewState()));
    }
    
    private void SetViewState(IViewState state)
    {
        _currentViewState = state;
        state.Apply(this);
    }
    
    public void SetViewMenuChecks(bool preview, bool source, bool split)
    {
        togglePreviewToolStripMenuItem.Checked = preview;
        toggleSourceViewToolStripMenuItem.Checked = source;
        splitViewToolStripMenuItem.Checked = split;
    }
}
