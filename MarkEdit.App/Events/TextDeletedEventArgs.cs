namespace MarkEdit.App.Events;

public class TextDeletedEventArgs : EventArgs
{
    public int Position { get; }
    public string DeletedText { get; }

    public TextDeletedEventArgs(int position, string deletedText)
    {
        Position = position;
        DeletedText = deletedText;
    }
}
