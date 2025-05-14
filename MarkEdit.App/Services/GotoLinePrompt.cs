using MarkEdit.App.Forms;
using MarkEdit.App.Properties;

namespace MarkEdit.App.Services;

public static class GotoLinePrompt
{
    public static int GetLineNumber()
    {
        var form = new PromptForm();
        form.Text = Resources.GotoLinePrompt_Title;
        form.InputLabel = Resources.GotoLinePrompt_InputLabel;
        form.ShowDialog();

        if (int.TryParse(form.InputValue, out var lineNumber))
        {
            return lineNumber;
        }
        return -1;
    }
}