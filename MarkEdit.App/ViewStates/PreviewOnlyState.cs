using MarkEdit.App.Forms;

namespace MarkEdit.App.ViewStates;

public class PreviewOnlyState : IViewState
{
    public void Apply(MainForm form)
    {
        form.SplitContainer.Panel1Collapsed = true; // Hide TextBox
        form.SplitContainer.Panel2Collapsed = false; // Show WebView

        form.SetViewMenuChecks(true, false, false);
    }
}