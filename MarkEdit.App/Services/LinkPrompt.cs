using MarkEdit.App.Forms;
using MarkEdit.App.Properties;

namespace MarkEdit.App.Services;

public static class LinkPrompt
{
    public static string GetUrlLink()
    {
        var form = new PromptForm();
        form.Text = Resources.LinkPrompt_Title;
        form.InputLabel = Resources.LinkPrompt_InputLabel;
        form.ShowDialog();
        
        return form.InputValue;
    }
}