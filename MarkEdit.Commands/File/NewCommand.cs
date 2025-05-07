using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.File;

public class NewCommand : ICommand
{
    private readonly Document _document;
    private readonly ITextEditor _editor;

    public NewCommand(Document document, ITextEditor editor)
    {
        _document = document;
        _editor = editor;
    }

    public void Execute()
    {
        _document.Content = string.Empty;
        _document.FilePath = null;
        _document.IsDirty = false;
        _editor.Text = string.Empty;
    }

    public bool CanExecute() => true;
}