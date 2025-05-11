using MarkEdit.App.Forms;

namespace MarkEdit.App.ViewStates;

public interface IViewState
{
    void Apply(MainForm form);
}
