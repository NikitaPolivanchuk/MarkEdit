using MarkEdit.Core;

namespace MarkEdit.Commands.List;

public class BulletListCommand : ListCommandBase
{
    public BulletListCommand(ITextEditor editor) : base(editor) { }
    
    protected override string GetListPrefix(int index) => "-";
}