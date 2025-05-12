using System.Text.Json;
using MarkEdit.App.States.App;

namespace MarkEdit.App.Services;

public class JsonAppStateService : IAppStateService
{
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true
    };
    
    private readonly string _settingsPath;

    public JsonAppStateService()
    {
        _settingsPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "MarkEdit",
            "appstate.json");

        Directory.CreateDirectory(Path.GetDirectoryName(_settingsPath)!);
    }

    public AppState Load()
    {
        if (!File.Exists(_settingsPath))
        {
            return new AppState();
        }

        var json = File.ReadAllText(_settingsPath);
        return JsonSerializer.Deserialize<AppState>(json) ?? new AppState();
    }

    public void Save(AppState state)
    {
        var json = JsonSerializer.Serialize(state, Options);
        File.WriteAllText(_settingsPath, json);
    }
}