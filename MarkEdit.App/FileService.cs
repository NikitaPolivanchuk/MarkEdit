using MarkEdit.Core;

namespace MarkEdit.App;

public class FileService : IFileService
{
    public string? OpenFile()
    {
        using var ofd = new OpenFileDialog();
        ofd.Filter = "Markdown Files|*.md|All Files|*.*";
        return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
    }

    public string? SaveFile(string? currentPath)
    {
        if (!string.IsNullOrEmpty(currentPath))
        {
            return currentPath;
        }

        using var sfd = new SaveFileDialog();
        sfd.Filter = "Markdown Files|*.md|All Files|*.*";
        return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : null;
    }

    public string ReadFile(string path) 
        => File.ReadAllText(path);
    
    public void WriteFile(string path, string content) 
        => File.WriteAllText(path, content);
    
}