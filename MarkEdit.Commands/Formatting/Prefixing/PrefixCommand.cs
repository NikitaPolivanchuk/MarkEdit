using MarkEdit.Core;

namespace MarkEdit.Commands.Formatting.Prefixing;

public abstract class PrefixCommand : FormatCommand
{
    protected readonly string Prefix;
    private int _selectionStart;
    private int _selectionLength;

    protected PrefixCommand(string prefix, ITextEditor editor)
        :base(editor)
    {
        Prefix = $"{prefix} ";
    }
    
    public override void Execute()
    {
        var startLine = Editor.GetLineFromCharIndex(OriginalSelectionStart);
        var endLine = Editor.GetLineFromCharIndex(OriginalSelectionStart + OriginalSelectionLength - 1);

        var start = Editor.GetFirstCharIndexFromLine(startLine);
        var end = Editor.GetFirstCharIndexFromLine(endLine) + Editor.Lines[endLine].Length;

        Editor.Select(start, end - start);

        var lines = Editor.SelectedText.Split(Environment.NewLine); 
        var prefixing = lines.Any(line => !Prefixed(line));

        for (var i = 0; i < lines.Length; i++)
        {
            if (!prefixing || !Prefixed(lines[i]))
            {
                lines[i] = TogglePrefix(lines[i]);
            }
        }
        var text = string.Join(Environment.NewLine, lines);
        _selectionStart = start;
        _selectionLength = text.Length;
        
        Editor.SelectedText = text;
        Editor.Select(start, _selectionLength);
    }

    public override void Undo()
    {
        Editor.Select(_selectionStart, _selectionLength);
        Editor.SelectedText = OriginalText;
    }

    protected bool Prefixed(string line)
    {
        var text = line.Trim();
        return text.StartsWith(Prefix);
    }

    protected abstract string TogglePrefix(string line);

    public override bool CanExecute() => true;
}