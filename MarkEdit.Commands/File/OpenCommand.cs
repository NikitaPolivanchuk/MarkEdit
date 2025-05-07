using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.File;

public class OpenCommand : ICommand
{
    private readonly Document _document;
    private readonly IFileService _fileService;
    private readonly ITextEditor _editor;

    public OpenCommand(Document document, IFileService fileService, ITextEditor editor)
    {
        _document = document;
        _fileService = fileService;
        _editor = editor;
    }

    public void Execute()
    {
        var filePath = _fileService.OpenFile();
        if (filePath == null)
            return;

        var content = _fileService.ReadFile(filePath);

        _document.FilePath = filePath;
        _document.Content = content;
        _document.IsDirty = false;

        _editor.Text = content;
    }

    public bool CanExecute() => true;
}