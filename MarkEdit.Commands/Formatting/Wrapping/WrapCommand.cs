using MarkEdit.Core;

namespace MarkEdit.Commands.Formatting.Wrapping;

public abstract class WrapCommand : FormatCommand
{
    private readonly string _marker;
    private int _selectionLength;
    
    protected WrapCommand(string marker, ITextEditor editor)
        : base(editor)
    {
        _marker = marker;
    }

    public override void Execute()
    {
        Editor.Select(OriginalSelectionStart, OriginalSelectionLength);
        
        if (!IsMultiline())
        {
            ApplyFormatting(ToggleWrap(Editor.SelectedText));
            return;
        }
        
        var lines = Editor.SelectedText.Split(Environment.NewLine);
        var wrapping = lines.Any(line => !Wrapped(line.Trim()));

        for (var i = 0; i < lines.Length; i++)
        {
            if (!wrapping || !Wrapped(lines[i].Trim()))
            {
                lines[i] = ToggleWrap(lines[i]);
            }
        }
        
        ApplyFormatting(string.Join("\n", lines));
    }

    public override void Undo()
    {
        Editor.Select(OriginalSelectionStart, _selectionLength);
        ApplyFormatting(OriginalText);
    }
    
    public override bool CanExecute() 
        => OriginalSelectionLength > 0;

    protected abstract bool Wrapped(string text);

    private string ToggleWrap(string text)
    {
        var leading = GetLeadingSpaces(text);
        var trailing = GetTrailingSpaces(text);
        
        var core = text.Trim();
        core = Wrapped(core)
            ? core.Substring(_marker.Length, core.Length - _marker.Length * 2)
            : $"{_marker}{core}{_marker}";
        
        return string.Concat(leading, core, trailing);
    }

    private void ApplyFormatting(string text)
    {
        _selectionLength = text.Length;
        Editor.SelectedText = text;
        Editor.Select(OriginalSelectionStart, _selectionLength);
    }
    
    private static string GetLeadingSpaces(string line)
    {
        var index = 0;
        while (index < line.Length && char.IsWhiteSpace(line[index]))
        {
            index++;
        }
        return line.Substring(0, index);
    }
    
    private static string GetTrailingSpaces(string line)
    {
        var index = line.Length - 1;
        while (index >= 0 && char.IsWhiteSpace(line[index]))
        {
            index--;
        }
        return line.Substring(index + 1);
    }
}