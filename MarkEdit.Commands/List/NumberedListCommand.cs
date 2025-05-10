using MarkEdit.Core;

namespace MarkEdit.Commands.List;

public class NumberedListCommand : ListCommandBase
{
    public NumberedListCommand(ITextEditor editor) : base(editor) { }
    
    protected override string GetListPrefix(int index) => $"{index + 1}.";
}