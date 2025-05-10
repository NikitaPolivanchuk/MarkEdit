using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Basic;

public class DeleteCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly int _position;
    private readonly string _deletedText;

    public DeleteCommand(ITextEditor editor, int position, string deletedText)
    {
        _editor = editor;
        _position = position;
        _deletedText = deletedText;
    }

    public void Execute()
    {
        _editor.Text = _editor.Text.Remove(_position, _deletedText.Length);
    }

    public bool CanExecute() => true;

    public void Undo()
    {
        _editor.Text = _editor.Text.Insert(_position, _deletedText);
    }
}