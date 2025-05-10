using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.List;

public class ContinueListCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly string _insertedText;
    private readonly int _insertPosition;

    public ContinueListCommand(ITextEditor editor, string insertedText, int position)
    {
        _editor = editor;
        _insertedText = insertedText;
        _insertPosition = position;
    }

    public void Execute()
    {
        if (!string.IsNullOrEmpty(_insertedText.Trim()))
        {
            _editor.Text = _editor.Text.Insert(_insertPosition, _insertedText);
            _editor.SelectionStart = _insertPosition + _insertedText.Length;
            return;
        }
        var lineIndex = _editor.GetLineFromCharIndex(_insertPosition);
        var start = _editor.GetFirstCharIndexFromLine(lineIndex);
        _editor.Select(start, _insertPosition - start);
        _editor.SelectedText = string.Empty;
    }

    public void Undo()
    {
        _editor.Select(_insertPosition, _insertedText.Length);
        _editor.SelectedText = string.Empty;
        _editor.SelectionStart = _insertPosition;
    }
    
    public bool CanExecute() => true;
}