using System.Text.RegularExpressions;

namespace MarkEdit.Core.List;

public partial class NumberedListContinuationStrategy : ListContinuationStrategy
{
    [GeneratedRegex(@"^\s*(\d+)\.\s+", RegexOptions.Compiled)]
    private static partial Regex ItemRegex();
    
    protected override Regex Pattern => ItemRegex();

    protected override string GetNextMarker(string prev)
        => $"{int.Parse(prev) + 1}.";
}