using MarkEdit.Commands.List;
using MarkEdit.Core;
using MarkEdit.Core.Commands;
using MarkEdit.Core.List;

namespace MarkEdit.App.Services;

public class ListContinuationHelper
{
    private readonly List<IListContinuationStrategy> _strategies = new()
    {
        new BulletListContinuationStrategy(),
        new NumberedListContinuationStrategy(),
    };

    public IRevertibleCommand? GetContinuationCommand(ITextEditor editor)
    {
        var lineIndex = editor.GetLineFromCharIndex(editor.SelectionStart);
        if (lineIndex < 0 || lineIndex >= editor.Lines.Length)
        {
            return null;
        }

        var currentLine = editor.Lines[lineIndex];
        var cursor = editor.SelectionStart;

        foreach (var strategy in _strategies)
        {
            if (strategy.Matches(currentLine))
            {
                var insertText = strategy.GetInsertText(currentLine);
                return new ContinueListCommand(editor, insertText, cursor);
            }
        }
        
        return null;
    }
}