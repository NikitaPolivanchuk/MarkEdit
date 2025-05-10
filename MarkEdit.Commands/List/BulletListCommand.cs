using System.Text.RegularExpressions;
using MarkEdit.Core;

namespace MarkEdit.Commands.List;

public partial class BulletListCommand : ListCommandBase
{
    [GeneratedRegex(@"^\s*-\s+")]
    private static partial Regex ItemRegex();
    
    public BulletListCommand(ITextEditor editor) 
        : base(editor)
    { }
    
    protected override string GetListPrefix(int index) => "-";
    
    protected override Regex ListItemRegex => ItemRegex();
}