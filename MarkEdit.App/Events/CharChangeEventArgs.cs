namespace MarkEdit.App.Events;

public class CharChangeEventArgs : EventArgs
{
    public int Position { get; }
    public char Character { get; }

    public bool Handled { get; set; }

    public CharChangeEventArgs(int position, char character)
    {
        Position = position;
        Character = character;
    }
}