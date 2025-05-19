# MarkEdit

## Lines verification

![image](https://github.com/NikitaPolivanchuk/MarkEdit/blob/main/lines%20verify.png)

## General

### User interface

#### Menu bar with options:
- File: New, Open, Save, Save As, Exit
- Edit: Undo, Redo, Cut, Copy, Paste, Find, Replace, Go To, Select All
- View: Toggle Preview, Toggle Source View, Split View
- Format: Bold, Italic, Code, Headings (H1–H6), Lists (Bullet, Numbered),
 
#### Quick Access Toolbar:
- File operations (New, Open, Save, Save As)
- Clipboard operations (Cut, Copy, Paste)
- Undo/Redo
- Formatting buttons (Bold, Italic, Code, Quote, Headings, Lists, Link)

#### Split screen editor:
- Markdown source editor
- HTML preview panel

#### Search Panel:
- Input for search term
- Next/Previous match navigation

#### Status Bar:  
- Displays current line and column number


### Editor Logic & Functionality

#### Markdown Editing:
- Live update of preview pane using [Markdig](https://github.com/xoofx/markdig)
- Manual formatting via commands or shortcuts
- Support for headings, bold, italic, code, quotes, lists, and links

#### Undo/Redo Support:
- Managed through a command manager with up to 200 actions

#### Search Functionality:
- Case-insensitive search with "Next" and "Previous" support
- Automatic match highlighting and navigation


### File Management

#### Document Operations:
- New, Open, Save, Save As functionality
- Tracks last opened file path and loads it on startup
- Updates editor state and preview on file change

#### Clipboard Integration:
- Cut, Copy, Paste support via platform clipboard


### Application Settings
- Saves last opened file and preferred view mode (Source/Preview/Split)
- Automatically restores on next launch


## Programming Principles

### SOLID Principles

####  Single Responsibility Principle
- Each command encapsulates a single operation and its execution logic
- [`CharChangeEventArgs`](https://github.com/NikitaPolivanchuk/MarkEdit/blob/main/MarkEdit.App/Events/CharChangeEventArgs.cs) and [`TextDeletedEventArgs`](https://github.com/NikitaPolivanchuk/MarkEdit/blob/main/MarkEdit.App/Events/TextDeletedEventArgs.cs) are responsible only for encapsulating the specific event data for text editing events

#### Open/Closed Principle
- ICommand: all commands implement ICommand and can be added or extended without modifying CommandManager.
- Formatting Commands: each command is designed to be extended without altering existing ones.

#### Liskov Substitution
- `ExtendedTextBox` can be used anywhere a `TextBox` is expected, while adding new events
- Classes like `MainForm` use `ITextEditor`, which is implemented by `TextBoxAdapter`. Any other class implementing `ITextEditor` could substitute it

#### Interface Segregation Principle
- [`ICommand`](https://github.com/NikitaPolivanchuk/MarkEdit/blob/main/MarkEdit.Core/Commands/ICommand.cs) & [`IRevertableCommand`](https://github.com/NikitaPolivanchuk/MarkEdit/blob/main/MarkEdit.Core/Commands/IRevertibleCommand.cs): clients that only need to execute commands are not burdened with undo-related logic

#### Dependency Inversion Principle
- Commands rely on abstractions like `IClipboard`, `ITextEditor`, `IFileService`
- `CommandManager` depends on `ICommand` interface for extensibility and abstraction, not specific command types

### DRY
Commands with similar logic grouped and have base class:
- [Formatting commands](https://github.com/NikitaPolivanchuk/MarkEdit/tree/main/MarkEdit.Commands/Formatting)
- [List commands](https://github.com/NikitaPolivanchuk/MarkEdit/tree/main/MarkEdit.Commands/List)

###  Composition Over Inheritance
MainForm composes multiple services (IClipboard, ITextEditor, IFileService, etc.) instead of inheriting from base functionality

### Program to Interfaces, Not Implementations
Commands rely on abstractions like `IClipboard`, `ITextEditor`, `IFileService` and never tied to TextBox or Clipboard directly


### Fail Fast
OnCharacterInsert immediately returns if internal command state is detected, preventing unintended behavior.
```
if (_commandManager.InternalChange) return;
```

Search updates reset index immediately if the panel isn’t visible:
```
if (!searchPanel.Visible) return;
```

## Design Patterns

### Command Pattern

All user actions are encapsulated in command classes that implement the ICommand interface

Why it was used:
- To encapsulate editing logic into reusable, composable objects
- Enables centralized undo/redo functionality using CommandManager
- Decouples UI elements from the logic they trigger

### Adapter Pattern

TextBoxAdapter adapts System.Windows.Forms.TextBox to the ITextEditor interface
ClipboardAdapter adapts Clipboard to IClipboard

Why it was used:
- To isolate UI components from the application logic.
- Makes it easier to mock or swap implementations

### State Pattern

Used to manage view layout modes (PreviewOnlyState, SourceOnlyState, SplitViewState), all implementing IViewState

Why It Was Used:
- To encapsulate different UI layout behaviors in their own classes
- Simplifies switching views at runtime without bloating MainForm logic

### Strategy Pattern

List continuation are delegated to specific strategy-like classes

Why it was used:
- To abstract list continuation logic into a swappable component


## Refactoring Techniques
 
### Extract Method

In MainForm.cs multiple responsibilities are broken into helper methods
```
public MainForm()
{
    InitializeComponent();
    InitializeWebView();
    InitializeServices();
    RegisterTextEditorEvents();
    WireUpMenuStripCommands();
    ...
}
```


### Replace Conditional with Polymorphism

Each view state encapsulates specific behavior instead of using a big if/switch elsewhere.


### Extract Superclass

Commands with similar logic grouped and have base class

### Introduce Variable

In `OnTextChanged` method:
```
var index = textBox.SelectionStart;
var line = textBox.GetLineFromCharIndex(index);
var column = index - textBox.GetFirstCharIndexOfCurrentLine();
```

### Replace Magic Value

Template for status label is loaded from resourse file:

```
toolStripStatusLabel.Text = string.Format(Resources.ToolStripStatusLabel, line + 1, column + 1);


```
