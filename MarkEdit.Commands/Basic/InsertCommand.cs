using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Basic;

public class InsertCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly int _position;
    private readonly char _insertedChar;

    public InsertCommand(ITextEditor editor, int position, char insertedChar)
    {
        _editor = editor;
        _position = position;
        _insertedChar = insertedChar;
    }

    public void Execute()
    {
        _editor.Text = _editor.Text.Insert(_position, _insertedChar.ToString());
        _editor.SelectionStart = _position + 1;
    }

    public bool CanExecute() => true;

    public void Undo()
    {
        _editor.Text = _editor.Text.Remove(_position, 1);
        _editor.SelectionStart = _position;
    }
}