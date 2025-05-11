using System.Text.RegularExpressions;

namespace MarkEdit.Core.List;

public partial class BulletListContinuationStrategy : ListContinuationStrategy
{
    [GeneratedRegex(@"^\s*([-*+])\s+", RegexOptions.Compiled)]
    private static partial Regex ItemRegex();
    
    protected override Regex Pattern => ItemRegex();

    protected override string GetNextMarker(string prev) => prev;
}