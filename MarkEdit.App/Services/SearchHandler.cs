using MarkEdit.App.Controls;
using MarkEdit.Commands.Replace;
using MarkEdit.Commands.Search;
using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.App.Services;

public class SearchHandler
{
    private readonly SearchReplaceControl _control;
    private readonly ITextEditor _editor;
    private readonly CommandManager _commandManager;
    private readonly SearchContext _searchContext;

    public SearchHandler(
        SearchReplaceControl control,
        ITextEditor editor,
        CommandManager commandManager,
        SearchContext searchContext)
    {
        _control = control;
        _editor = editor;
        _commandManager = commandManager;
        _searchContext = searchContext;

        WireEvents();
    }

    private void WireEvents()
    {
        _control.SearchTextChanged += (_, _) =>
        {
            if (_control.Visible)
            {
                _searchContext.CurrentTerm = _control.SearchTextBox.Text;
                _searchContext.LastMatchIndex = -1;
            }
        };

        _control.SearchTextBox.KeyDown += (_, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _editor.Focus();
                _commandManager.Execute(new FindNextCommand(_editor, _searchContext));
            }
        };

        _control.SearchNextClicked += (_, _) =>
        {
            _editor.Focus();
            _commandManager.Execute(new FindNextCommand(_editor, _searchContext));
        };

        _control.SearchPreviousClicked += (_, _) =>
        {
            _editor.Focus();
            _commandManager.Execute(new FindPreviousCommand(_editor, _searchContext));
        };

        _control.ReplaceClicked += (_, _) =>
        {
            _editor.Focus();
            if (_editor.SelectionLength == 0)
            {
                _commandManager.Execute(new FindNextCommand(_editor, _searchContext));
            }

            _commandManager.Execute(new ReplaceCommand(
                _editor,
                _searchContext,
                _control.ReplaceTextBox.Text));
        };

        _control.ReplaceAllClicked += (_, _) =>
        {
            _editor.Focus();
            _commandManager.Execute(new ReplaceAllCommand(
                _editor,
                _control.SearchTextBox.Text,
                _control.ReplaceTextBox.Text));
        };
    }
}