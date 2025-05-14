using MarkEdit.App.Events;
using MarkEdit.App.Extensions;
using MarkEdit.App.Properties;

namespace MarkEdit.App.Controls;

public partial class SearchReplaceControl : UserControl
{
    public event EventHandler? SearchTextChanged;
    public event EventHandler? SearchNextClicked;
    public event EventHandler? SearchPreviousClicked;
    public event EventHandler? ReplaceClicked;
    public event EventHandler? ReplaceAllClicked;
    public event EventHandler<ButtonClickEventArgs>? CloseClicked;
    
    public TextBox ReplaceTextBox => replaceTextbox;
    public TextBox SearchTextBox => searchTextbox;

    public SearchReplaceControl()
    {
        InitializeComponent();

        showPreviousButton.Image = Resources.arrow_up.ResizeImage(showPreviousButton.ClientSize, 4);
        showNextButton.Image = Resources.arrow_down.ResizeImage(showNextButton.ClientSize, 4);
        toggleReplaceButton.Image = Resources.caret_up.ResizeImage(toggleReplaceButton.ClientSize, 4);
    }
    
    public void ShowReplacePanel()
    {
        replacePanel.Visible = true;
        toggleReplaceButton.Image = Resources.caret_down.ResizeImage(toggleReplaceButton.ClientSize, 4);
    }

    public void HideReplacePanel()
    {
        replacePanel.Visible = false;
        toggleReplaceButton.Image = Resources.caret_up.ResizeImage(toggleReplaceButton.ClientSize, 4);
    }
    
    private void SearchTextbox_TextChanged(object sender, EventArgs e)
    {
        SearchTextChanged?.Invoke(this, e);
    }

    private void ShowNextButton_Click(object sender, EventArgs e)
    {
        SearchNextClicked?.Invoke(this, e);
    }

    private void ShowPreviousButton_Click(object sender, EventArgs e)
    {
        SearchPreviousClicked?.Invoke(this, e);
    }

    private void ReplaceButton_Click(object sender, EventArgs e)
    {
        ReplaceClicked?.Invoke(this, e);
    }

    private void ReplaceAllButton_Click(object sender, EventArgs e)
    {
        ReplaceAllClicked?.Invoke(this, e);
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        var args = new ButtonClickEventArgs();
        CloseClicked?.Invoke(this, args);
        if (!args.Handled)
        {
            Hide();
        }
    }

    private void ToggleReplaceButton_Click(object sender, EventArgs e)
    {
        if (replacePanel.Visible)
        {
            HideReplacePanel();
        }
        else
        {
            ShowReplacePanel();
        }
        
    }
}