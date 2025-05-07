using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.File;

public class SaveCommand : ICommand
{
    private readonly Document _document;
    private readonly IFileService _fileService;
    private readonly ITextEditor _editor;

    public SaveCommand(Document document, IFileService fileService, ITextEditor editor)
    {
        _document = document;
        _fileService = fileService;
        _editor = editor;
    }

    public void Execute()
    {
        var path = _fileService.SaveFile(_document.FilePath);
        if (path == null)
            return;

        _document.Content = _editor.Text;
        _document.FilePath = path;
        _document.IsDirty = false;

        _fileService.WriteFile(path, _document.Content);
    }

    public bool CanExecute() => true;
}