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
    
    private string _newText;

    protected ListCommandBase(ITextEditor editor)
    {
        _editor = editor;
        _selectionStart = editor.SelectionStart;
        _selectionLength = editor.SelectionLength;
        _originalText = editor.SelectedText;
        _newText = string.Empty;
    }
    
    protected abstract string GetListPrefix(int index);
    protected abstract Regex ListItemRegex { get; }
    
    public void Execute()
    {
        _editor.Select(_selectionStart, _selectionLength);
        var selectedText = _editor.SelectedText;
        
        var lines = selectedText.Split(Environment.NewLine);
        var isAlreadyList = lines.Any(line => ListItemRegex.IsMatch(line));
        
        _newText = isAlreadyList 
            ? RemoveListFormatting(lines)
            : ApplyListFormatting(lines);

        _editor.SelectedText = _newText;
        _editor.Select(_selectionStart, _newText.Length);
    }
    
    private string RemoveListFormatting(string[] lines)
    {
        for (var i = 0; i < lines.Length; i++)
        {
            lines[i] = RemovePrefix(lines[i]);
        }
        return string.Join(Environment.NewLine, lines);
    }
    
    private string RemovePrefix(string line)
    {
        var match = ListItemRegex.Match(line);
        return match.Success 
            ? line.Substring(match.Length).TrimStart()
            : line;
    }
    
    private string ApplyListFormatting(string[] lines)
    {
        for (var i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            var indentMatch = Regex.Match(line, @"^\s*");
            var indent = indentMatch.Value;
            lines[i] = $"{indent}{GetListPrefix(i)} {line.TrimStart()}";
        }
        return string.Join(Environment.NewLine, lines);
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