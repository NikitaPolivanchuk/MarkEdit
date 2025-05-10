using System.Text.RegularExpressions;
using MarkEdit.Core;

namespace MarkEdit.Commands.List;

public partial class NumberedListCommand : ListCommandBase
{
    [GeneratedRegex(@"^\s*\d+\.\s+")]
    private static partial Regex ItemRegex();
    
    public NumberedListCommand(ITextEditor editor) 
        : base(editor) 
    { }
    
    protected override string GetListPrefix(int index) => $"{index + 1}.";
    
    protected override Regex Pattern => ItemRegex();
}