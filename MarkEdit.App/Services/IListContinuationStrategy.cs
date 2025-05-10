namespace MarkEdit.App.Services;

public interface IListContinuationStrategy
{
    bool Matches(string line);
    string GetInsertText(string line);
}