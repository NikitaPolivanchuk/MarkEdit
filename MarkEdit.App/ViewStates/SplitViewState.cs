using MarkEdit.App.Forms;

namespace MarkEdit.App.ViewStates;

public class SplitViewState : IViewState
{
    public void Apply(MainForm form)
    {
        form.SplitContainer.Panel1Collapsed = false;
        form.SplitContainer.Panel2Collapsed = false;

        form.SetViewMenuChecks(false, false, true);
    }
}