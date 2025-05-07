using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Clipboard;

public class CutCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly IClipboard _clipboard;
    private readonly string _cutText;
    private readonly int _selectionStart;
    private readonly int _selectionLength;

    public CutCommand(ITextEditor editor, IClipboard clipboard)
    {
        _editor = editor;
        _clipboard = clipboard;
        _cutText = _editor.SelectedText;
        _selectionStart = _editor.SelectionStart;
        _selectionLength = _editor.SelectionLength;

        if (CanExecute())
        {
            _clipboard.SetText(_cutText);
        }
    }

    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);
        _editor.SelectedText = string.Empty;
    }

    public bool CanExecute() => !string.IsNullOrEmpty(_cutText) && _clipboard.HasText();

    public void Undo()
    {
        _editor.Select(_selectionStart, 0);
        _editor.SelectedText = _cutText;
    }
}