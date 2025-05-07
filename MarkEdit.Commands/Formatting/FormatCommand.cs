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

    public abstract bool CanExecute();

    public abstract void Undo();
    
    protected bool IsMultiline()
        => Editor.SelectedText.Contains(Environment.NewLine);
}