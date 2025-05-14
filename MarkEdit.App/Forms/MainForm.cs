using Markdig;
using MarkEdit.App.Adapters;
using MarkEdit.App.Events;
using MarkEdit.App.Properties;
using MarkEdit.App.Services;
using MarkEdit.App.States.App;
using MarkEdit.App.States.View;
using MarkEdit.Commands;
using MarkEdit.Commands.Basic;
using MarkEdit.Commands.Clipboard;
using MarkEdit.Commands.File;
using MarkEdit.Commands.Formatting.Prefixing;
using MarkEdit.Commands.Formatting.Wrapping;
using MarkEdit.Commands.List;
using MarkEdit.Commands.Search;
using MarkEdit.Core;
using MarkEdit.Core.Commands;
using Microsoft.Web.WebView2.Core;

namespace MarkEdit.App.Forms;

public partial class MainForm : Form
{
    private CommandManager _commandManager = null!;
    private ITextEditor _editor = null!;
    private IClipboard _clipboard = null!;
    private Document _document = null!;
    private IFileService _fileService = null!;
    private ListContinuationHelper _listContinuation = null!;
    private IAppStateService _appStateService = null!;
    private AppState _appState = null!;
    private SearchContext _searchContext = null!;
    private ViewStateManager _viewStateManager = null!;
    private CommandBinder _commandBinder = null!;
    
    public SplitContainer SplitContainer => splitContainer;

    public MainForm()
    {
        InitializeComponent();
        InitializeServices();
        InitializeWebView();
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
        _listContinuation = new ListContinuationHelper();
        _appStateService = new JsonAppStateService();
        _appState = _appStateService.Load();
        _searchContext = new SearchContext();
        _viewStateManager = new ViewStateManager(this, _appState);
        _commandBinder = new CommandBinder(_commandManager);
        
        SearchHandler.WireEvents(searchReplaceControl, _editor, _commandManager, _searchContext);
    }

    private void InitializeWebView()
    {
        webView.CoreWebView2InitializationCompleted += (_, e) =>
        {
            if (e.IsSuccess)
            {
                webView.CoreWebView2.NavigationStarting += CoreWebView2_NavigationStarting;
                UpdatePreview(_editor.Text);
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

    #region CommandsBinding

    private void WireUpMenuStripCommands()
    {
        //File commands
        _commandBinder.Bind(newToolStripMenuItem, () => new NewCommand(_document, _editor));
        _commandBinder.Bind(openToolStripMenuItem, () => WithFilePathUpdate(new OpenCommand(_document, _fileService, _editor)));
        _commandBinder.Bind(saveToolStripMenuItem, () => WithFilePathUpdate(new SaveCommand(_document, _fileService, _editor)));
        _commandBinder.Bind(saveAsToolStripMenuItem, () => WithFilePathUpdate(new SaveAsCommand(_document, _fileService, _editor)));
        _commandBinder.Bind(exitToolStripMenuItem, Application.Exit);

        //Clipboard commands
        _commandBinder.Bind(cutToolStripMenuItem, () => new CutCommand(_editor, _clipboard));
        _commandBinder.Bind(copyToolStripMenuItem, () => new CopyCommand(_editor, _clipboard));
        _commandBinder.Bind(pasteToolStripMenuItem, () => new PasteCommand(_editor, _clipboard));

        //History commands
        _commandBinder.Bind(undoToolStripMenuItem, _commandManager.Undo);
        _commandBinder.Bind(redoToolStripMenuItem, _commandManager.Redo);

        //Formatting commands
        _commandBinder.Bind(boldToolStripMenuItem, () => new BoldCommand(_editor));
        _commandBinder.Bind(italicToolStripMenuItem, () => new ItalicCommand(_editor));
        _commandBinder.Bind(h1ToolStripMenuItem, () => new HeaderCommand(_editor, 1));
        _commandBinder.Bind(h2ToolStripMenuItem, () => new HeaderCommand(_editor, 2));
        _commandBinder.Bind(h3ToolStripMenuItem, () => new HeaderCommand(_editor, 3));
        _commandBinder.Bind(h4ToolStripMenuItem, () => new HeaderCommand(_editor, 4));
        _commandBinder.Bind(h5ToolStripMenuItem, () => new HeaderCommand(_editor, 5));
        _commandBinder.Bind(h6ToolStripMenuItem, () => new HeaderCommand(_editor, 6));

        //Inserting commands
        _commandBinder.Bind(linkToolStripMenuItem, () => new LinkCommand(_editor, LinkPrompt.GetUrlLink()));

        //List commands
        _commandBinder.Bind(bulletListToolStripMenuItem, () => new BulletListCommand(_editor));
        _commandBinder.Bind(numberedListToolStripMenuItem, () => new NumberedListCommand(_editor));

        //Searching + Replacing commands
        _commandBinder.Bind(findToolStripMenuItem, () =>
        {
            searchReplaceControl.Show();
            searchReplaceControl.SearchTextBox.Focus();
            searchReplaceControl.SearchTextBox.SelectAll();
        });
        _commandBinder.Bind(findNextToolStripMenuItem, () => new FindNextCommand(_editor, _searchContext));
        _commandBinder.Bind(findPreviousToolStripMenuItem, () => new FindPreviousCommand(_editor, _searchContext));
        _commandBinder.Bind(replaceToolStripMenuItem, () =>
        {
            searchReplaceControl.Show();
            searchReplaceControl.ShowReplacePanel();
            searchReplaceControl.SearchTextBox.Focus();
            searchReplaceControl.SearchTextBox.SelectAll();
        });

        //Selecting commands
        _commandBinder.Bind(selectAllToolStripMenuItem, textBox.SelectAll);

        //Navigation commands
        _commandBinder.Bind(goToToolStripMenuItem, () => new GoToCommand(_editor, GotoLinePrompt.GetLineNumber()));
    }

    private void WireUpQuickAccessCommands()
    {
        //File commands
        _commandBinder.Bind(newQuickAccessButton, () => new NewCommand(_document, _editor));
        _commandBinder.Bind(openQuickAccessButton, () => WithFilePathUpdate(new OpenCommand(_document, _fileService, _editor)));
        _commandBinder.Bind(saveQuickAccessButton, () => WithFilePathUpdate(new SaveCommand(_document, _fileService, _editor)));
        _commandBinder.Bind(saveAsQuickAccessButton, () => WithFilePathUpdate(new SaveAsCommand(_document, _fileService, _editor)));

        //Clipboard commands
        _commandBinder.Bind(cutQuickAccessButton, () => new CutCommand(_editor, _clipboard));
        _commandBinder.Bind(copyQuickAccessButton, () => new CopyCommand(_editor, _clipboard));
        _commandBinder.Bind(pasteQuickAccessButton, () => new PasteCommand(_editor, _clipboard));

        //History commands
        _commandBinder.Bind(undoQuickAccessButton, _commandManager.Undo);
        _commandBinder.Bind(redoQuickAccessButton, _commandManager.Redo);

        //Formatting commands
        _commandBinder.Bind(boldQuickAccessButton, () => new BoldCommand(_editor));
        _commandBinder.Bind(italicQuickAccessButton, () => new ItalicCommand(_editor));
        _commandBinder.Bind(quoteQuickAccessButton, () => new QuoteCommand(_editor));
        _commandBinder.Bind(codeQuickAccessButton, () => new CodeCommand(_editor));
        _commandBinder.Bind(h1QuickAccessItem, () => new HeaderCommand(_editor, 1));
        _commandBinder.Bind(h2QuickAccessItem, () => new HeaderCommand(_editor, 2));
        _commandBinder.Bind(h3QuickAccessItem, () => new HeaderCommand(_editor, 3));
        _commandBinder.Bind(h4QuickAccessItem, () => new HeaderCommand(_editor, 4));
        _commandBinder.Bind(h5QuickAccessItem, () => new HeaderCommand(_editor, 5));
        _commandBinder.Bind(h6QuickAccessItem, () => new HeaderCommand(_editor, 6));

        //Inserting commands
        _commandBinder.Bind(linkQuickAccessButton, () => new LinkCommand(_editor, LinkPrompt.GetUrlLink()));

        //List commands
        _commandBinder.Bind(bulletListQuickAccessButton, () => new BulletListCommand(_editor));
        _commandBinder.Bind(numberedListQuickAccessButton, () => new NumberedListCommand(_editor));
    }

    private void WireUpContextMenuCommands()
    {
        textBox.ContextMenuStrip = contextMenuStrip;

        //History commands
        _commandBinder.Bind(undoContextMenuItem, _commandManager.Undo);
        _commandBinder.Bind(redoContextMenuItem, _commandManager.Redo);

        //Clipboard commands
        _commandBinder.Bind(cutContextMenuItem, () => new CutCommand(_editor, _clipboard));
        _commandBinder.Bind(copyContextMenuItem, () => new CopyCommand(_editor, _clipboard));
        _commandBinder.Bind(pasteContextMenuItem, () => new PasteCommand(_editor, _clipboard));

        //Formatting commands
        _commandBinder.Bind(boldContextMenuItem, () => new BoldCommand(_editor));
        _commandBinder.Bind(italicContextMenuItem, () => new ItalicCommand(_editor));
        _commandBinder.Bind(codeContextMenuItem, () => new CodeCommand(_editor));

        //Inserting commands
        _commandBinder.Bind(linkContextMenuItem, () => new LinkCommand(_editor, LinkPrompt.GetUrlLink()));

        //Selecting commands
        _commandBinder.Bind(selectAllContextMenuItem, textBox.SelectAll);
    }
    
    private void WireUpViewMenuCommands()
    {
        _commandBinder.Bind(togglePreviewToolStripMenuItem, () => _viewStateManager.Apply(new PreviewOnlyState()));
        _commandBinder.Bind(toggleSourceViewToolStripMenuItem, () => _viewStateManager.Apply(new SourceOnlyState()));
        _commandBinder.Bind(splitViewToolStripMenuItem, () => _viewStateManager.Apply(new SplitViewState()));
    }
    
    #endregion

    private void OnTextChanged(object? sender, EventArgs e)
    {
        var index = textBox.SelectionStart;
        var line = textBox.GetLineFromCharIndex(index);
        var column = index - textBox.GetFirstCharIndexOfCurrentLine();

        toolStripStatusLabel.Text = string.Format(Resources.ToolStripStatusLabel, line + 1, column + 1);

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
        webView.CoreWebView2?.NavigateToString($"<html><body>{html}</body></html>");
    }
    
    private void WithFilePathUpdate(ICommand command)
    {
        _commandManager.Execute(command);
        _appState.LastOpenedFilePath = _document.FilePath;
    }

    private void CoreWebView2_NavigationStarting(object? sender, CoreWebView2NavigationStartingEventArgs e)
    {
        if (e.IsUserInitiated)
        {
            e.Cancel = true;
        }
    }

    internal void SetViewMenuChecks(bool preview, bool source, bool split)
    {
        togglePreviewToolStripMenuItem.Checked = preview;
        toggleSourceViewToolStripMenuItem.Checked = source;
        splitViewToolStripMenuItem.Checked = split;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(_appState.LastOpenedFilePath) && File.Exists(_appState.LastOpenedFilePath))
        {
            _document.Load(_appState.LastOpenedFilePath);
            _editor.Text = _document.Content;
        }

        IViewState viewState = _appState.ViewState switch
        {
            ViewStateType.Preview => new PreviewOnlyState(),
            ViewStateType.Source => new SourceOnlyState(),
            _ => new SplitViewState(),
        };

        _viewStateManager.Apply(viewState);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _appStateService.Save(_appState);
        base.OnFormClosing(e);
    }
    
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData != Keys.Escape || !searchReplaceControl.Visible)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        searchReplaceControl.Hide();
        searchReplaceControl.HideReplacePanel();
        textBox.Focus();
        return true;
    }
}
