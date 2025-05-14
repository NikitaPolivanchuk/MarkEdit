using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Replace;

public class ReplaceCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly SearchContext _searchContext;
    private readonly string _originalText;
    private readonly int _selectionStart;
    private readonly int _selectionLength;
    private readonly string _replaceText;

    public ReplaceCommand(ITextEditor editor, SearchContext searchContext, string replaceText)
    {
        _editor = editor;
        _searchContext = searchContext;
        _originalText = _editor.SelectedText;
        _selectionStart = _editor.SelectionStart;
        _selectionLength = _editor.SelectionLength;
        _replaceText = replaceText;
    }
    
    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);
        _editor.SelectedText = _replaceText;
        _searchContext.LastMatchIndex = _editor.SelectionStart;
    }

    public void Undo()
    {
        _editor.Select(_selectionStart, _replaceText.Length);
        _editor.SelectedText = _originalText;
        _searchContext.LastMatchIndex = _editor.SelectionStart;
    }
    
    public bool CanExecute()
        => _selectionLength != 0;
}