using MarkEdit.Core;

namespace MarkEdit.Commands.Formatting.Wrapping;

public class ItalicCommand : WrapCommand
{
    public ItalicCommand(ITextEditor editor) 
        : base("*", editor)
    { }

    protected override bool Wrapped(string text)
    {
        if (!text.StartsWith('*') || !text.EndsWith('*'))
            return false;
        
        if (text.StartsWith("***") && text.EndsWith("***"))
            return true;
        
        if (text.StartsWith("**") && text.EndsWith("**"))
            return false;
        
        return true;
    }
}