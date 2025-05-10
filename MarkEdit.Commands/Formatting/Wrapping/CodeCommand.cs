using MarkEdit.Core;

namespace MarkEdit.Commands.Formatting.Wrapping;

public class CodeCommand : FormatCommand
{
    private int _selectionLength;
    
    public CodeCommand(ITextEditor editor)
        : base(editor)
    { }

    public override void Execute()
    {
        Editor.Select(OriginalSelectionStart, OriginalSelectionLength);

        ApplyFormatting(IsMultiline()
            ? ToggleBlock(Editor.SelectedText)
            : ToggleInline(Editor.SelectedText)
        );
    }

    public override void Undo()
    {
        Editor.Select(OriginalSelectionStart, OriginalSelectionLength);
        Editor.SelectedText = OriginalText;
    }

    private string ToggleInline(string text)
    {
        var leading = GetLeadingSpaces(text);
        var trailing = GetTrailingSpaces(text);
        
        var core = text.Trim();

        if (core.Length == 0)
        {
            return string.Empty;
        }
        
        core = core.StartsWith('`') && core.EndsWith('`')
            ? core.Substring(1, core.Length - 2)
            : $"`{core}`";
        
        return string.Concat(leading, core, trailing);
    }

    private string ToggleBlock(string text)
    {
        var trimmed = text.Trim();

        if (trimmed.StartsWith("```") && trimmed.EndsWith("```"))
        {
            var lines = trimmed.Split(Environment.NewLine);
            return string.Join(Environment.NewLine, lines.Skip(1).Take(lines.Length - 2));
        }

        return $"```{Environment.NewLine}{text}{Environment.NewLine}```";
    }
    
    private void ApplyFormatting(string text)
    {
        _selectionLength = text.Length;
        Editor.SelectedText = text;
        Editor.Select(OriginalSelectionStart, _selectionLength);
    }
}