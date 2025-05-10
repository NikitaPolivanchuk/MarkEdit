using MarkEdit.App.Forms;
using MarkEdit.Core;

namespace MarkEdit.App.Services;

public class LinkPromptProvider : ILinkProvider
{
    public string GetUrlLink()
    {
        var form = new PromptForm();
        form.Text = "Insert Link";
        form.InputLabel = "Enter the URL";
        form.ShowDialog();
        
        return form.InputValue;
    }
}