using System.Text.RegularExpressions;
using MarkEdit.Core;

namespace MarkEdit.App.Services;

public class BulletListStrategy : IListContinuationStrategy
{
    private static readonly Regex Pattern = new(@"^\s*([-*])\s+", RegexOptions.Compiled);

    public bool Matches(string line) => Pattern.IsMatch(line);

    public string GetInsertText(string line)
    {
        var match = Pattern.Match(line);
        var indent = GetIndentation(line);
        var bullet = match.Groups[1].Value;

        return string.IsNullOrWhiteSpace(line.Substring(match.Length))
            ? "\r\n"
            : $"\r\n{indent}{bullet} ";
    }

    private static string GetIndentation(string line)
    {
        int i = 0;
        while (i < line.Length && char.IsWhiteSpace(line[i])) i++;
        return line[..i];
    }
}