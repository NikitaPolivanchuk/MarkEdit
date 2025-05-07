using MarkEdit.Core;

namespace MarkEdit.Commands.Formatting.Prefixing;

public class HeaderCommand : PrefixCommand
{
    public HeaderCommand(ITextEditor editor, int level) 
        : base(new string('#', level), editor)
    { }

    protected override string TogglePrefix(string line)
    {
        var leading = GetLeadingSpaces(line);
        var text = line.TrimStart();
        
        var i = 0;
        while (i < text.Length && text[i] == '#')
        {
            i++;
        }
        if (i < line.Length && line[i] == ' ')
        {
            i++;
        }
        
        text = Prefixed(text)
            ? text.Substring(Prefix.Length)
            : $"{Prefix}{text.Substring(i)}";
        
        return string.Concat(leading, text);
    }
}