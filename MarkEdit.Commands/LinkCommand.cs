using System.Net;
using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands;

public class LinkCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly string _originalText;
    private readonly int _selectionStart;
    private readonly int _selectionLength;
    private readonly string? _url;
    
    private int _newSelectionLength;

    public LinkCommand(ITextEditor editor, ILinkProvider linkProvider)
    {
        _editor = editor;
        _originalText = _editor.SelectedText;
        _selectionStart = _editor.SelectionStart;
        _selectionLength = _editor.SelectionLength;
        if (_selectionLength > 0)
        {
            _url = linkProvider.GetUrlLink();
        }
    }

    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);

        var link = $"[{_editor.SelectedText}]({WebUtility.UrlEncode(_url)})";
        _newSelectionLength = link.Length;
        _editor.SelectedText = link;
        _editor.Select(_selectionStart, _newSelectionLength);
    }

    public void Undo()
    {
        _editor.Select(_selectionStart, _newSelectionLength);
        _editor.SelectedText = _originalText;
    }
    
    public bool CanExecute()
        => !string.IsNullOrEmpty(_url);
}