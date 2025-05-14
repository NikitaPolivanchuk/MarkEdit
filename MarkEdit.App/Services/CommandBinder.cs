using MarkEdit.Core.Commands;

namespace MarkEdit.App.Services;

public class CommandBinder
{
    private readonly CommandManager _commandManager;

    public CommandBinder(CommandManager commandManager)
    {
        _commandManager = commandManager;
    }
    
    public void Bind(ToolStripItem item, Func<ICommand> commandFactory)
    {
        item.Click += (_, _) => _commandManager.Execute(commandFactory());
    }
    
    public void Bind(ToolStripItem item, Action action)
    {
        item.Click += (_, _) => action();
    }
}