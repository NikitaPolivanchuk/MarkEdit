using MarkEdit.App.Forms;

namespace MarkEdit.App.Services;

public static class LinkPrompt
{
    public static string GetUrlLink()
    {
        var form = new PromptForm();
        form.Text = "Insert Link";
        form.InputLabel = "Enter the URL";
        form.ShowDialog();
        
        return form.InputValue;
    }
}