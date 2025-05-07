namespace MarkEdit.Core.Commands;

public class CommandManager
{
    private readonly LinkedList<IRevertibleCommand> _undoStack = [];
    private readonly Stack<IRevertibleCommand> _redoStack = [];
    private readonly int _maxHistorySize;

    public CommandManager(int maxHistorySize)
    {
        _maxHistorySize = maxHistorySize;
    }

    public bool InternalChange { get; private set; }

    public void Execute(ICommand command)
    {
        if (!command.CanExecute())
        {
            return;
        }
        
        InternalChange = true;
        command.Execute();
        InternalChange = false;
        
        if (command is IRevertibleCommand undoable)
        {
            Save(undoable);
        }
    }

    public void Save(IRevertibleCommand command)
    {
        if (_undoStack.Count >= _maxHistorySize)
        {
            _undoStack.RemoveFirst();
        }
        
        _undoStack.AddLast(command);
        _redoStack.Clear();
    }

    public void Undo()
    {
        if (_undoStack.Count == 0)
        {
            return;
        }

        var command = _undoStack.Last();
        _undoStack.RemoveLast();
        
        InternalChange = true;
        command.Undo();
        InternalChange = false;
        
        _redoStack.Push(command);
    }

    public void Redo()
    {
        if (_redoStack.Count == 0)
        {
            return;
        }
        
        var command = _redoStack.Pop();
        
        InternalChange = true;
        command.Execute();
        InternalChange = false;
        
        _undoStack.AddLast(command);
    }
}