using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Clipboard;

public class CopyCommand : ICommand
{
    private readonly ITextEditor _editor;
    private readonly IClipboard _clipboard;

    public CopyCommand(ITextEditor editor, IClipboard clipboard)
    {
        _editor = editor;
        _clipboard = clipboard;
    }

    public void Execute()
    {
        _clipboard.SetText(_editor.SelectedText);
    }

    public bool CanExecute() => !string.IsNullOrEmpty(_editor.SelectedText);
}