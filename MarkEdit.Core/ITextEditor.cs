namespace MarkEdit.Core;

public interface ITextEditor
{
    string Text { get; set; }
    string SelectedText { get; set; }
    int SelectionStart { get; set; }
    int SelectionLength { get; set; }
    string[] Lines { get; set; }
    
    void Select(int start, int length);
    int GetLineFromCharIndex(int index);
    int GetFirstCharIndexFromLine(int index);
}