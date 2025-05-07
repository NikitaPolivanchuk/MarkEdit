using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Formatting;

public class HeaderDecreaseCommand : HeaderChangeCommand
{
    public HeaderDecreaseCommand(ITextEditor editor) : base(editor) { }

    protected override int NewLevel
    {
        get
        {
            var level = OriginalLevel - 1;
            return level < 0 ? 6 : level;
        }
    }
}