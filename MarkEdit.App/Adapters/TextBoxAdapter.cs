using MarkEdit.Core;

namespace MarkEdit.App.Adapters;

public class TextBoxAdapter : ITextEditor
{
    private readonly TextBox _textBox;

    public TextBoxAdapter(TextBox textBox)
    {
        _textBox = textBox;
    }

    public string Text
    {
        get => _textBox.Text;
        set => _textBox.Text = value;
    }

    public string SelectedText
    {
        get => _textBox.SelectedText;
        set => _textBox.SelectedText = value;
    }

    public int SelectionStart
    {
        get => _textBox.SelectionStart;
        set => _textBox.SelectionStart = value;
    }

    public int SelectionLength
    {
        get => _textBox.SelectionLength;
        set => _textBox.SelectionLength = value;
    }

    public string[] Lines
    {
        get => _textBox.Lines;
        set => _textBox.Lines = value;
    }
    
    public string CurrentLine
    {
        get
        {
            var lineIndex = _textBox.GetLineFromCharIndex(_textBox.SelectionStart);
            return lineIndex >= 0 && lineIndex < _textBox.Lines.Length
                ? _textBox.Lines[lineIndex]
                : string.Empty;
        }
    }
    
    public void Select(int start, int length)
    {
        _textBox.Select(start, length);
    }

    public int GetLineFromCharIndex(int index)
    {
        return _textBox.GetLineFromCharIndex(index);
    }

    public int GetFirstCharIndexFromLine(int index)
    {
        return _textBox.GetFirstCharIndexFromLine(index);
    }
}