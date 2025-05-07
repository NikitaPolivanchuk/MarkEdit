using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Clipboard;

public class PasteCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly IClipboard _clipboard;
    private readonly string _pastedText;
    private readonly string _originalText;
    private readonly int _selectionStart;
    private readonly int _selectionLength;

    public PasteCommand(ITextEditor editor, IClipboard clipboard)
    {
        _editor = editor;
        _clipboard = clipboard;
        _pastedText = _clipboard.GetText();
        _originalText = _editor.SelectedText;
        _selectionStart = _editor.SelectionStart;
        _selectionLength = _editor.SelectionLength;
    }

    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);
        _editor.SelectedText = _pastedText;
    }

    public bool CanExecute() => _clipboard.HasText();

    public void Undo()
    {
        _editor.Select(_selectionStart, _pastedText.Length);
        _editor.SelectedText = _originalText;
    }
}