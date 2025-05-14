namespace MarkEdit.Core;

public interface ITextEditor
{
    string Text { get; set; }
    string SelectedText { get; set; }
    int SelectionStart { get; set; }
    int SelectionLength { get; set; }
    string[] Lines { get; set; }
    
    string CurrentLine { get; }
    
    void Select(int start, int length);
    int GetLineFromCharIndex(int index);
    int GetFirstCharIndexFromLine(int index);
    void ScrollToCaret();
    bool Focus();
}