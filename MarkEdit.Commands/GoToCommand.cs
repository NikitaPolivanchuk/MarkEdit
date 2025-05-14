using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands;

public class GoToCommand : ICommand
{
    private readonly ITextEditor _editor;
    private readonly int _targetLine;

    public GoToCommand(ITextEditor editor, int targetLine)
    {
        _editor = editor;
        _targetLine = targetLine;
    }

    public bool CanExecute()
    {
        return _targetLine >= 1 && _targetLine <= _editor.Lines.Length;
    }

    public void Execute()
    {
        var charIndex = _editor.GetFirstCharIndexFromLine(_targetLine - 1);
        _editor.Select(charIndex, 0);
        _editor.ScrollToCaret();
    }
}