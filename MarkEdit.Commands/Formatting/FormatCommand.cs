using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Formatting;

public abstract class FormatCommand : IRevertibleCommand
{
    protected readonly ITextEditor Editor;
    protected readonly string OriginalText;
    protected readonly int OriginalSelectionStart;
    protected readonly int OriginalSelectionLength;

    protected FormatCommand(ITextEditor editor)
    {
        Editor = editor;
        OriginalText = editor.SelectedText;
        OriginalSelectionStart = editor.SelectionStart;
        OriginalSelectionLength = editor.SelectionLength;
    }
    
    public abstract void Execute();

    public virtual bool CanExecute()
        => OriginalSelectionLength > 0;

    public abstract void Undo();
    
    protected bool IsMultiline()
        => Editor.SelectedText.Contains(Environment.NewLine);
    
    protected static string GetLeadingSpaces(string line)
    {
        var index = 0;
        while (index < line.Length && char.IsWhiteSpace(line[index]))
        {
            index++;
        }
        return line.Substring(0, index);
    }
    
    protected static string GetTrailingSpaces(string line)
    {
        var index = line.Length - 1;
        while (index >= 0 && char.IsWhiteSpace(line[index]))
        {
            index--;
        }
        return line.Substring(index + 1);
    }
}