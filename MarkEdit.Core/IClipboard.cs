namespace MarkEdit.Core;

public interface IClipboard
{
    void SetText(string text);
    string GetText();
    bool HasText();
}