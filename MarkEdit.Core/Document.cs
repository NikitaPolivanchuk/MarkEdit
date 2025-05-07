namespace MarkEdit.Core;

public class Document
{
    public string Content { get; set; } = string.Empty;
    public string? FilePath { get; set; }
    public bool IsDirty { get; set; }
}