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
        
        ApplyFormatting(string.Join(Environment.NewLine, lines));
    }

    public override void Undo()
    {
        Editor.Select(OriginalSelectionStart, _selectionLength);
        ApplyFormatting(OriginalText);
    }

    protected abstract bool Wrapped(string text);

    private string ToggleWrap(string text)
    {
        var leading = GetLeadingSpaces(text);
        var trailing = GetTrailingSpaces(text);
        
        var core = text.Trim();

        if (core.Length == 0)
        {
            return string.Empty;
        }
        
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
}