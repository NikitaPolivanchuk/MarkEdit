namespace MarkEdit.Core;

public interface IFileService
{
    string? OpenFile();
    string? SaveFile(string? currentPath);
    string ReadFile(string path);
    void WriteFile(string path, string content);
}