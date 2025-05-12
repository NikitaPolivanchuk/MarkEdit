namespace MarkEdit.Core;

public class SearchContext
{
    public string? CurrentTerm { get; set; }
    public int LastMatchIndex { get; set; } = -1;
}