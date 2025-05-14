using MarkEdit.App.Controls;
using MarkEdit.Commands.Replace;
using MarkEdit.Commands.Search;
using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.App.Services;

public static class SearchHandler
{
    public static void WireEvents(
        SearchReplaceControl control,
        ITextEditor editor,
        CommandManager commandManager,
        SearchContext searchContext)
    {
        WireSearchTextChanged(control, searchContext);
        WireSearchKeyDown(control, editor, commandManager, searchContext);
        WireSearchNavigation(control, editor, commandManager, searchContext);
        WireReplace(control, editor, commandManager, searchContext);
    }

    private static void WireSearchTextChanged(SearchReplaceControl control, SearchContext searchContext)
    {
        control.SearchTextChanged += (_, _) =>
        {
            if (control.Visible)
            {
                searchContext.CurrentTerm = control.SearchTextBox.Text;
                searchContext.LastMatchIndex = -1;
            }
        };
    }

    private static void WireSearchKeyDown(
        SearchReplaceControl control,
        ITextEditor editor,
        CommandManager commandManager,
        SearchContext searchContext)
    {
        control.SearchTextBox.KeyDown += (_, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                editor.Focus();
                commandManager.Execute(new FindNextCommand(editor, searchContext));
            }
        };
    }

    private static void WireSearchNavigation(
        SearchReplaceControl control,
        ITextEditor editor,
        CommandManager commandManager,
        SearchContext searchContext)
    {
        control.SearchNextClicked += (_, _) =>
        {
            editor.Focus();
            commandManager.Execute(new FindNextCommand(editor, searchContext));
        };

        control.SearchPreviousClicked += (_, _) =>
        {
            editor.Focus();
            commandManager.Execute(new FindPreviousCommand(editor, searchContext));
        };
    }

    private static void WireReplace(
        SearchReplaceControl control,
        ITextEditor editor,
        CommandManager commandManager,
        SearchContext searchContext)
    {
        control.ReplaceClicked += (_, _) =>
        {
            editor.Focus();
            if (editor.SelectionLength == 0)
            {
                commandManager.Execute(new FindNextCommand(editor, searchContext));
            }

            commandManager.Execute(new ReplaceCommand(
                editor,
                searchContext,
                control.ReplaceTextBox.Text));
        };

        control.ReplaceAllClicked += (_, _) =>
        {
            editor.Focus();
            commandManager.Execute(new ReplaceAllCommand(
                editor,
                control.SearchTextBox.Text,
                control.ReplaceTextBox.Text));
        };
    }
}