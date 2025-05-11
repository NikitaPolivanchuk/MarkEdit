using MarkEdit.App.Forms;

namespace MarkEdit.App.ViewStates;

public class SourceOnlyState : IViewState
{
    public void Apply(MainForm form)
    {
        form.SplitContainer.Panel1Collapsed = false; // Show TextBox
        form.SplitContainer.Panel2Collapsed = true; // Hide WebView

        form.SetViewMenuChecks(false, true, false);
    }
}