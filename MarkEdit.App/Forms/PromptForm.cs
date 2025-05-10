namespace MarkEdit.App.Forms;

public partial class PromptForm : Form
{
    public PromptForm()
    {
        InitializeComponent();
        acceptButton.Click += (_, _) => Close();
    }

    public string InputLabel
    {
        get => textLabel.Text;
        set => textLabel.Text = value;
    }

    public string InputValue => textbox.Text;
}