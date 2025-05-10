using System.Net;
using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands;

public class LinkCommand : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly ILinkProvider _linkProvider;
    private readonly string _originalText;
    private readonly int _selectionStart;
    private readonly int _selectionLength;
    
    private string? _url;
    private bool _requested;
    private int _newSelectionLength;

    public LinkCommand(ITextEditor editor, ILinkProvider linkProvider)
    {
        _editor = editor;
        _linkProvider = linkProvider;
        _originalText = _editor.SelectedText;
        _selectionStart = _editor.SelectionStart;
        _selectionLength = _editor.SelectionLength;
    }

    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);

        if (!_requested)
        {
            _url = _linkProvider.GetUrlLink();
            _requested = true;
        }

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
        => _selectionLength > 0;
}