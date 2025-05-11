using MarkEdit.App.States.App;

namespace MarkEdit.App.Services;

public interface IAppStateService
{
    AppState Load();
    void Save(AppState state);
}