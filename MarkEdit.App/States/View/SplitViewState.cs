using MarkEdit.App.Forms;
using MarkEdit.App.States.View;

namespace MarkEdit.App.States.View;

public class SplitViewState : IViewState
{
    public void Apply(MainForm form)
    {
        form.SplitContainer.Panel1Collapsed = false;
        form.SplitContainer.Panel2Collapsed = false;

        form.SetViewMenuChecks(false, false, true);
    }
}