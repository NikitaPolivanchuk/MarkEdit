using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Replace;

public class ReplaceAllCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly string _sourceText;
    private readonly string _replaceText;
    
    public ReplaceAllCommand(ITextEditor editor, string sourceText, string replaceText)
    {
        _editor = editor;
        _sourceText = sourceText;
        _replaceText = replaceText;
    }

    public void Execute()
    {
        _editor.Text = _editor.Text.Replace(_sourceText, _replaceText);
    }
    
    public void Undo()
    {
        _editor.Text = _editor.Text.Replace(_replaceText, _sourceText);
    }

    public bool CanExecute()
        => !string.IsNullOrWhiteSpace(_sourceText);
}
