namespace MarkEdit.Core;

public class Document
{
    public string Content { get; set; } = string.Empty;
    public string? FilePath { get; set; }
    public bool IsDirty { get; set; }
    
    public void Load(string filePath)
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
        {
            throw new FileNotFoundException("The specified file does not exist.", filePath);
        }
        
        Content = File.ReadAllText(filePath);
        FilePath = filePath;
        IsDirty = false;
    }
}