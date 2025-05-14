using MarkEdit.App.Forms;
using MarkEdit.App.States.App;
using MarkEdit.App.States.View;

namespace MarkEdit.App.Services;

public class ViewStateManager
{
    private readonly MainForm _form;
    private readonly AppState _appState;

    public ViewStateManager(MainForm form, AppState appState)
    {
        _form = form;
        _appState = appState;
    }

    public void Apply(IViewState state)
    {
        state.Apply(_form);

        _appState.ViewState = state switch
        {
            PreviewOnlyState => ViewStateType.Preview,
            SourceOnlyState => ViewStateType.Source,
            _ => ViewStateType.Split
        };

        UpdateMenuChecks();
    }
    
    private void UpdateMenuChecks()
    {
        var viewStateType = _appState.ViewState;

        _form.SetViewMenuChecks(
            preview: viewStateType == ViewStateType.Preview,
            source: viewStateType == ViewStateType.Source,
            split: viewStateType == ViewStateType.Split
        );
    }
}