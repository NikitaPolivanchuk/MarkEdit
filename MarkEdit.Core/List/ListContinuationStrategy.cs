using System.Text.RegularExpressions;

namespace MarkEdit.Core.List;

public abstract class ListContinuationStrategy : IListContinuationStrategy
{
    private static string GetIndentation(string line)
    {
        var i = 0;
        while (i < line.Length && char.IsWhiteSpace(line[i]))
        {
            i++;
        }
        return line.Substring(0, i);
    }
    
    protected abstract Regex Pattern { get; }
    protected abstract string GetNextMarker(string prev);
    
    public bool Matches(string line)
        => Pattern.IsMatch(line);

    public string GetInsertText(string line)
    {
        var match = Pattern.Match(line);
        var indent = GetIndentation(line);
        var marker = GetNextMarker(match.Groups[1].Value);

        return string.IsNullOrWhiteSpace(line.Substring(match.Length))
            ? Environment.NewLine
            : $"{Environment.NewLine}{indent}{marker} ";
    }
}