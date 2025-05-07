namespace MarkEdit.Core.Commands;

public interface IRevertibleCommand : ICommand
{
    void Undo();
}