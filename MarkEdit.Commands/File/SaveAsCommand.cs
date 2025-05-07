using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.File;

public class SaveAsCommand : ICommand
{
    private readonly Document _document;
    private readonly IFileService _fileService;
    private readonly ITextEditor _editor;

    public SaveAsCommand(Document document, IFileService fileService, ITextEditor editor)
    {
        _document = document;
        _fileService = fileService;
        _editor = editor;
    }

    public void Execute()
    {
        var path = _fileService.SaveFile(null);
        if (path == null)
            return;

        _document.Content = _editor.Text;
        _document.FilePath = path;
        _document.IsDirty = false;

        _fileService.WriteFile(path, _document.Content);
    }

    public bool CanExecute() 
        => !string.IsNullOrWhiteSpace(_document.Content)
           && (_document.IsDirty || !string.IsNullOrEmpty(_document.FilePath));
}