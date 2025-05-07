using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Formatting;

public class QuoteCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly string _originalText;
    private readonly int _selectionStart;
    private readonly int _selectionLength;

    public QuoteCommand(ITextEditor editor)
    {
        _editor = editor;
        _originalText = _editor.SelectedText;
        _selectionStart = _editor.SelectionStart;
        _selectionLength = _editor.SelectionLength;
    }
    
    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);
        _editor.SelectedText = $"> {_originalText}";
    }

    public void Undo()
    {
        _editor.Select(_selectionStart, _selectionLength + 2);
        _editor.SelectedText = _originalText;
    }
    
    public bool CanExecute() => _editor.SelectionLength > 0;


    private bool Formatted(string line)
        => line.StartsWith('>');
    
}