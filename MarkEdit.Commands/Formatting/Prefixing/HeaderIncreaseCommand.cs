using MarkEdit.Core;

namespace MarkEdit.Commands.Formatting;

public class HeaderIncreaseCommand : HeaderChangeCommand
{
    public HeaderIncreaseCommand(ITextEditor editor) : base(editor) { }


    protected override int NewLevel => (OriginalLevel + 1) % 7;
}