using MarkEdit.App.States.View;

namespace MarkEdit.App.States.App;

public class AppState
{
    public string? LastOpenedFilePath { get; set; }
    public ViewStateType ViewState { get; set; } = ViewStateType.Split;
}