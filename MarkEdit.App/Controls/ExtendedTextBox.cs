using MarkEdit.App.Events;

namespace MarkEdit.App.Controls;

public class ExtendedTextBox : TextBox
{
    public event EventHandler<CharChangeEventArgs>? CharacterInserted;
    public event EventHandler<CharChangeEventArgs>? CharacterDeleted;

    private string _previousText = string.Empty;

    public ExtendedTextBox()
    {
        TextChanged += OnTextChanged;
        KeyPress += OnKeyPress;
    }
    
    private void OnKeyPress(object? sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\b')
        {
            return;
        }
        
        var ev = new CharChangeEventArgs(SelectionStart, e.KeyChar);
        CharacterInserted?.Invoke(this, ev);
        e.Handled = ev.Handled;
    }
    
    private void OnTextChanged(object? sender, EventArgs e)
    {
        var newText = Text;
        if (newText.Length < _previousText.Length)
        {
            var position = SelectionStart;
            CharacterDeleted?.Invoke(this, new CharChangeEventArgs(position, _previousText[position]));
        }
        _previousText = newText;
    }
}