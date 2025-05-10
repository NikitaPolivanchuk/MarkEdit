namespace MarkEdit.App;

public static class Prompt
{
    public static string ShowDialog(string text, string caption)
    {
        var prompt = new Form()
        {
            Width = 400,
            Height = 150,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen
        };
        var textLabel = new Label() { Left = 20, Top = 20, Text = text };
        var textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
        var confirmation = new Button() { Text = "OK", Left = 280, Width = 80, Top = 80 };
        confirmation.Click += (_, _) => { prompt.Close(); };
        prompt.Controls.Add(textBox);
        prompt.Controls.Add(confirmation);
        prompt.Controls.Add(textLabel);
        prompt.AcceptButton = confirmation;

        prompt.ShowDialog();
        return textBox.Text;
    }
}