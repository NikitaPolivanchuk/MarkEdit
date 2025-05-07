using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Formatting;

public abstract class HeaderChangeCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly int _selectionStart;
    private readonly int _selectionLength;
    private readonly string _originalText;
    private readonly string _newText;
    
    protected readonly int OriginalLevel;
    
    protected abstract int NewLevel { get; }

    protected HeaderChangeCommand(ITextEditor editor)
    {
        _editor = editor;
        _originalText = _editor.SelectedText;
        _selectionStart = _editor.SelectionStart;
        _selectionLength = _editor.SelectionLength;
        OriginalLevel = _originalText.TakeWhile(c => c == '#').Count();
        _newText = ApplyLevel();
    }

    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);
        _editor.SelectedText = _newText;
        _editor.Select(_selectionStart, _newText.Length);
    }

    public bool CanExecute() => _selectionLength > 0;

    public void Undo()
    {
        _editor.Select(_selectionStart, _newText.Length);
        _editor.SelectedText = _originalText;
        _editor.Select(_selectionStart, _selectionLength);
    }
    
    private string ApplyLevel()
    {
        var headerText = _originalText.TrimStart('#').Trim();
        if (NewLevel == 0)
        {
            return headerText;
        }
        var prefix = new string('#', NewLevel);
        return $"{prefix} {headerText}";
    }
}