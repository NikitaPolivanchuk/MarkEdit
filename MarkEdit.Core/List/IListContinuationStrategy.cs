namespace MarkEdit.Core.List;

public interface IListContinuationStrategy
{
    bool Matches(string line);
    string GetInsertText(string line);
}