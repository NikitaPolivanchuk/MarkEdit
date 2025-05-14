using MarkEdit.App.Forms;

namespace MarkEdit.App.Services;

public static class GotoLinePrompt
{
    public static int GetLineNumber()
    {
        var form = new PromptForm();
        form.Text = "Go to Line";
        form.InputLabel = "Enter Line number";
        form.ShowDialog();

        if (int.TryParse(form.InputValue, out var lineNumber))
        {
            return lineNumber;
        }
        return -1;
    }
}