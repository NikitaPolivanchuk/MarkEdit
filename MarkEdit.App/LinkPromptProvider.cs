using MarkEdit.Core;

namespace MarkEdit.App;

public class LinkPromptProvider : ILinkProvider
{
    public string GetUrlLink()
    {
        return Prompt.ShowDialog("Enter the URL", "Insert Link");
    }
}