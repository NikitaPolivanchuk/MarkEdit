using System.Text.RegularExpressions;
using MarkEdit.Core;

namespace MarkEdit.App.Services;

public class NumberedListStrategy : IListContinuationStrategy
{
    private static readonly Regex Pattern = new(@"^\s*(\d+)\.\s+", RegexOptions.Compiled);

    public bool Matches(string line) => Pattern.IsMatch(line);

    public string GetInsertText(string line)
    {
        var match = Pattern.Match(line);
        int number = int.Parse(match.Groups[1].Value);
        string indent = GetIndentation(line);

        return string.IsNullOrWhiteSpace(line.Substring(match.Length))
            ? "\r\n"
            : $"\r\n{indent}{number + 1}. ";
    }

    private static string GetIndentation(string line)
    {
        int i = 0;
        while (i < line.Length && char.IsWhiteSpace(line[i])) i++;
        return line[..i];
    }
}