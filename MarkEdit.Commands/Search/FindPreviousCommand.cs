using MarkEdit.Core;
using MarkEdit.Core.Commands;

namespace MarkEdit.Commands.Search;

public class FindPreviousCommand : ICommand
{
    private readonly ITextEditor _editor;
    private readonly SearchContext _context;

    public FindPreviousCommand(ITextEditor editor, SearchContext context)
    {
        _editor = editor;
        _context = context;
    }

    public void Execute()
    {
        if (string.IsNullOrEmpty(_context.CurrentTerm))
        {
            return;
        }

        var start = Math.Max(0, _context.LastMatchIndex - 1);
        var index = _editor.Text.LastIndexOf(_context.CurrentTerm, start, StringComparison.OrdinalIgnoreCase);
        if (index >= 0)
        {
            _editor.Select(index, _context.CurrentTerm.Length);
            _context.LastMatchIndex = index;
        }
    }

    public bool CanExecute()
        => !string.IsNullOrEmpty(_context.CurrentTerm);
}