using MarkEdit.Core;

namespace MarkEdit.Commands.Formatting.Wrapping;

public class BoldCommand : WrapCommand
{
    public BoldCommand(ITextEditor editor) 
        : base("**", editor)
    { }


    protected override bool Wrapped(string text)
        => text.StartsWith("**") && text.EndsWith("**");
}