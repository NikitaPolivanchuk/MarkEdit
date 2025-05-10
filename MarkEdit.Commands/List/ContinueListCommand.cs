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
        _editor.Text = _editor.Text.Insert(_insertPosition, _insertedText);
        _editor.SelectionStart = _insertPosition + _insertedText.Length;
    }

    public void Undo()
    {
        _editor.Text = _editor.Text.Remove(_insertPosition, _insertedText.Length);
        _editor.SelectionStart = _insertPosition;
    }
    
    public bool CanExecute() => true;
}