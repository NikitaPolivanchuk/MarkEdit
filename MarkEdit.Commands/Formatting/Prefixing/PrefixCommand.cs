using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Formatting.Prefixing;

public abstract class PrefixCommand : FormatCommand
{
    private readonly string _prefix;

    protected PrefixCommand(string prefix, ITextEditor editor)
        :base(editor)
    {
        _prefix = prefix;
    }
    
    public override void Execute()
    {
        Editor.Select(OriginalSelectionStart, OriginalSelectionLength);
        Editor.SelectedText = $"{_prefix} {OriginalText}";
    }

    public override void Undo()
    {
        Editor.Select(OriginalSelectionStart, OriginalSelectionLength + _prefix.Length + 1);
        Editor.SelectedText = OriginalText;
    }
    
    public override bool CanExecute() => Editor.SelectionLength > 0;


    private bool Formatted(string line)
        => line.StartsWith(_prefix);
}