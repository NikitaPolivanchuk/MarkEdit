using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Basic;

public class DeleteCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly int _position;
    private readonly char _deletedChar;

    public DeleteCommand(ITextEditor editor, int position, char deletedChar)
    {
        _editor = editor;
        _position = position;
        _deletedChar = deletedChar;
    }

    public void Execute()
    {
        _editor.Text = _editor.Text.Remove(_position, 1);
    }

    public bool CanExecute() => true;

    public void Undo()
    {
        _editor.Text = _editor.Text.Insert(_position, _deletedChar.ToString());
    }
}