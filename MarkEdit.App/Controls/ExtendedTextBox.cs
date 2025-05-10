using MarkEdit.App.Events;

namespace MarkEdit.App.Controls;

public class ExtendedTextBox : TextBox
{
    public event EventHandler<CharChangeEventArgs>? CharacterInserted;
    public event EventHandler<TextDeletedEventArgs>? TextDeleted;

    public ExtendedTextBox()
    {
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

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        if (e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
        {
            return;
        }
        
        var pos = SelectionStart;
        var lengthToDelete = SelectionLength;
        
        if (lengthToDelete == 0)
        {
            if (e.KeyCode == Keys.Back && pos > 0)
            {
                pos -= 1;
                lengthToDelete = 1;
            }
            else if (e.KeyCode == Keys.Delete && pos < Text.Length)
            {
                lengthToDelete = 1;
            }
        }
        
        if (lengthToDelete > 0 && pos >= 0 && (pos + lengthToDelete) <= Text.Length)
        {
            var deletedText = Text.Substring(pos, lengthToDelete);
            TextDeleted?.Invoke(this, new TextDeletedEventArgs(pos, deletedText));
        }
    }
}