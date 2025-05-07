using MarkEdit.Core;

namespace MarkEdit.Commands.Formatting.Prefixing;

public class QuoteCommand : PrefixCommand
{
    public QuoteCommand(ITextEditor editor)
        : base(">", editor)
    { }

    protected override string TogglePrefix(string line)
    {
        var leading = GetLeadingSpaces(line);

        var text = line.TrimStart();
        text = Prefixed(text)
            ? text.Substring(Prefix.Length)
            : $"{Prefix}{text}";
        
        return string.Concat(leading, text);
    }
}