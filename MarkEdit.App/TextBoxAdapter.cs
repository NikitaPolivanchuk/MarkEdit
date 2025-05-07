using MarkEdit.Core;

namespace MarkEdit.App;

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
    
    public void Select(int start, int length)
    {
        _textBox.Select(start, length);
    }
    
    public string CurrentLineText
    {
        get
        {
            var lineIndex = _textBox.GetLineFromCharIndex(_textBox.SelectionStart);
            return _textBox.Lines.Length > lineIndex ? _textBox.Lines[lineIndex] : string.Empty;
        }
    }
}