using System.Text.RegularExpressions;
using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.List;

public abstract class ListCommandBase : IRevertibleCommand
{
    private readonly ITextEditor _editor;
    private readonly int _selectionStart;
    private readonly int _selectionLength;
    private readonly string _originalText;
    private string _newText = string.Empty;

    protected ListCommandBase(ITextEditor editor)
    {
        _editor = editor;
        _selectionStart = editor.SelectionStart;
        _selectionLength = editor.SelectionLength;
        _originalText = editor.SelectedText;
    }
    
    protected abstract string GetListPrefix(int index);

    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);
        var selectedText = _editor.SelectedText;

        var lines = selectedText.Split(Environment.NewLine);
        for (var i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            var indentMatch = Regex.Match(line, @"^\s*");
            var indent = indentMatch.Value;
            lines[i] = $"{indent}{GetListPrefix(i)} {line.TrimStart()}";
        }
        
        _newText = string.Join(Environment.NewLine, lines);
        _editor.SelectedText = _newText;
        _editor.Select(_selectionStart, _newText.Length);
    }

    public void Undo()
    {
        _editor.Select(_selectionStart, _newText.Length);
        _editor.SelectedText = _originalText;
        _editor.Select(_selectionStart, _selectionLength);
    }

    public bool CanExecute()
        => _selectionLength > 0;
}