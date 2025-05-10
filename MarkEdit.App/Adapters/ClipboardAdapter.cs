using MarkEdit.Core;

namespace MarkEdit.App;

public class ClipboardAdapter : IClipboard
{
    public void SetText(string text) => Clipboard.SetText(text);

    public string GetText() => Clipboard.GetText();

    public bool HasText() => Clipboard.ContainsText();
}