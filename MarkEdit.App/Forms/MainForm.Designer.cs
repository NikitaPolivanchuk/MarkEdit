using MarkEdit.App.Controls;

namespace MarkEdit.App.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            findToolStripMenuItem = new ToolStripMenuItem();
            replaceToolStripMenuItem = new ToolStripMenuItem();
            goToToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            togglePreviewToolStripMenuItem = new ToolStripMenuItem();
            toggleSourceViewToolStripMenuItem = new ToolStripMenuItem();
            splitViewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator14 = new ToolStripSeparator();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            restoreToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            codeToolStripMenuItem = new ToolStripMenuItem();
            headingToolStripMenuItem = new ToolStripMenuItem();
            h1ToolStripMenuItem = new ToolStripMenuItem();
            h2ToolStripMenuItem = new ToolStripMenuItem();
            h3ToolStripMenuItem = new ToolStripMenuItem();
            h4ToolStripMenuItem = new ToolStripMenuItem();
            h5ToolStripMenuItem = new ToolStripMenuItem();
            h6ToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenu = new ToolStripMenuItem();
            bulletListToolStripMenuItem = new ToolStripMenuItem();
            numberedListToolStripMenuItem = new ToolStripMenuItem();
            linkToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            splitContainer = new SplitContainer();
            textBox = new ExtendedTextBox();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            quickAccess = new ToolStrip();
            newQuickAccessButton = new ToolStripButton();
            openQuickAccessButton = new ToolStripButton();
            saveQuickAccessButton = new ToolStripButton();
            saveAsQuickAccessButton = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            cutQuickAccessButton = new ToolStripButton();
            copyQuickAccessButton = new ToolStripButton();
            pasteQuickAccessButton = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            undoQuickAccessButton = new ToolStripButton();
            redoQuickAccessButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            headingToolStripDropDown = new ToolStripDropDownButton();
            h1QuickAccessItem = new ToolStripMenuItem();
            h2QuickAccessItem = new ToolStripMenuItem();
            h3QuickAccessItem = new ToolStripMenuItem();
            h4QuickAccessItem = new ToolStripMenuItem();
            h5QuickAccessItem = new ToolStripMenuItem();
            h6QuickAccessItem = new ToolStripMenuItem();
            boldQuickAccessButton = new ToolStripButton();
            italicQuickAccessButton = new ToolStripButton();
            quoteQuickAccessButton = new ToolStripButton();
            codeQuickAccessButton = new ToolStripButton();
            linkQuickAccessButton = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            bulletListQuickAccessButton = new ToolStripButton();
            numberedListQuickAccessButton = new ToolStripButton();
            contextMenuStrip = new ContextMenuStrip(components);
            undoContextMenuItem = new ToolStripMenuItem();
            redoContextMenuItem = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            cutContextMenuItem = new ToolStripMenuItem();
            copyContextMenuItem = new ToolStripMenuItem();
            pasteContextMenuItem = new ToolStripMenuItem();
            toolStripSeparator11 = new ToolStripSeparator();
            boldContextMenuItem = new ToolStripMenuItem();
            italicContextMenuItem = new ToolStripMenuItem();
            codeContextMenuItem = new ToolStripMenuItem();
            toolStripSeparator13 = new ToolStripSeparator();
            insertContextMenuStrip = new ToolStripMenuItem();
            linkContextMenuItem = new ToolStripMenuItem();
            toolStripSeparator12 = new ToolStripSeparator();
            selectAllContextMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            statusStrip.SuspendLayout();
            quickAccess.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, formatToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(700, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, findToolStripMenuItem, replaceToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator2, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(144, 22);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(144, 22);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(144, 22);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(144, 22);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(144, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(141, 6);
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(144, 22);
            findToolStripMenuItem.Text = "Find";
            // 
            // replaceToolStripMenuItem
            // 
            replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            replaceToolStripMenuItem.Size = new Size(144, 22);
            replaceToolStripMenuItem.Text = "Replace";
            // 
            // goToToolStripMenuItem
            // 
            goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            goToToolStripMenuItem.Size = new Size(144, 22);
            goToToolStripMenuItem.Text = "Go to";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(144, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { togglePreviewToolStripMenuItem, toggleSourceViewToolStripMenuItem, splitViewToolStripMenuItem, toolStripSeparator14, zoomToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // togglePreviewToolStripMenuItem
            // 
            togglePreviewToolStripMenuItem.Name = "togglePreviewToolStripMenuItem";
            togglePreviewToolStripMenuItem.Size = new Size(177, 22);
            togglePreviewToolStripMenuItem.Text = "Toggle Preview";
            // 
            // toggleSourceViewToolStripMenuItem
            // 
            toggleSourceViewToolStripMenuItem.Name = "toggleSourceViewToolStripMenuItem";
            toggleSourceViewToolStripMenuItem.Size = new Size(177, 22);
            toggleSourceViewToolStripMenuItem.Text = "Toggle Source View";
            // 
            // splitViewToolStripMenuItem
            // 
            splitViewToolStripMenuItem.Name = "splitViewToolStripMenuItem";
            splitViewToolStripMenuItem.Size = new Size(177, 22);
            splitViewToolStripMenuItem.Text = "Split View";
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new Size(174, 6);
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, toolStripSeparator5, restoreToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(177, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(127, 22);
            zoomInToolStripMenuItem.Text = "Zoom in";
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(127, 22);
            zoomOutToolStripMenuItem.Text = "Zoom out";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(124, 6);
            // 
            // restoreToolStripMenuItem
            // 
            restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            restoreToolStripMenuItem.Size = new Size(127, 22);
            restoreToolStripMenuItem.Text = "Restore";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boldToolStripMenuItem, italicToolStripMenuItem, codeToolStripMenuItem, headingToolStripMenuItem, listToolStripMenu, linkToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "F&ormat";
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            boldToolStripMenuItem.Size = new Size(168, 22);
            boldToolStripMenuItem.Text = "Bold";
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            italicToolStripMenuItem.Size = new Size(168, 22);
            italicToolStripMenuItem.Text = "Italic";
            // 
            // codeToolStripMenuItem
            // 
            codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            codeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oem3;
            codeToolStripMenuItem.Size = new Size(168, 22);
            codeToolStripMenuItem.Text = "Code";
            // 
            // headingToolStripMenuItem
            // 
            headingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { h1ToolStripMenuItem, h2ToolStripMenuItem, h3ToolStripMenuItem, h4ToolStripMenuItem, h5ToolStripMenuItem, h6ToolStripMenuItem });
            headingToolStripMenuItem.Name = "headingToolStripMenuItem";
            headingToolStripMenuItem.Size = new Size(168, 22);
            headingToolStripMenuItem.Text = "Heading Levels";
            // 
            // h1ToolStripMenuItem
            // 
            h1ToolStripMenuItem.Name = "h1ToolStripMenuItem";
            h1ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.D1;
            h1ToolStripMenuItem.Size = new Size(152, 22);
            h1ToolStripMenuItem.Text = "H1";
            // 
            // h2ToolStripMenuItem
            // 
            h2ToolStripMenuItem.Name = "h2ToolStripMenuItem";
            h2ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.D2;
            h2ToolStripMenuItem.Size = new Size(152, 22);
            h2ToolStripMenuItem.Text = "H2";
            // 
            // h3ToolStripMenuItem
            // 
            h3ToolStripMenuItem.Name = "h3ToolStripMenuItem";
            h3ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.D3;
            h3ToolStripMenuItem.Size = new Size(152, 22);
            h3ToolStripMenuItem.Text = "H3";
            // 
            // h4ToolStripMenuItem
            // 
            h4ToolStripMenuItem.Name = "h4ToolStripMenuItem";
            h4ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.D4;
            h4ToolStripMenuItem.Size = new Size(152, 22);
            h4ToolStripMenuItem.Text = "H4";
            // 
            // h5ToolStripMenuItem
            // 
            h5ToolStripMenuItem.Name = "h5ToolStripMenuItem";
            h5ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.D5;
            h5ToolStripMenuItem.Size = new Size(152, 22);
            h5ToolStripMenuItem.Text = "H5";
            // 
            // h6ToolStripMenuItem
            // 
            h6ToolStripMenuItem.Name = "h6ToolStripMenuItem";
            h6ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.D6;
            h6ToolStripMenuItem.Size = new Size(152, 22);
            h6ToolStripMenuItem.Text = "H6";
            // 
            // listToolStripMenu
            // 
            listToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { bulletListToolStripMenuItem, numberedListToolStripMenuItem });
            listToolStripMenu.Name = "listToolStripMenu";
            listToolStripMenu.Size = new Size(168, 22);
            listToolStripMenu.Text = "List";
            // 
            // bulletListToolStripMenuItem
            // 
            bulletListToolStripMenuItem.Name = "bulletListToolStripMenuItem";
            bulletListToolStripMenuItem.Size = new Size(131, 22);
            bulletListToolStripMenuItem.Text = "Bullet";
            // 
            // numberedListToolStripMenuItem
            // 
            numberedListToolStripMenuItem.Name = "numberedListToolStripMenuItem";
            numberedListToolStripMenuItem.Size = new Size(131, 22);
            numberedListToolStripMenuItem.Text = "Numbered";
            // 
            // linkToolStripMenuItem
            // 
            linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            linkToolStripMenuItem.Size = new Size(168, 22);
            linkToolStripMenuItem.Text = "Link";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(130, 22);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(130, 22);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // splitContainer
            // 
            splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer.Location = new Point(0, 49);
            splitContainer.Margin = new Padding(3, 2, 3, 2);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(textBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(webView);
            splitContainer.Size = new Size(700, 261);
            splitContainer.SplitterDistance = 347;
            splitContainer.TabIndex = 1;
            // 
            // textBox
            // 
            textBox.AcceptsTab = true;
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(0, 0);
            textBox.Margin = new Padding(3, 2, 3, 2);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Size = new Size(347, 261);
            textBox.TabIndex = 0;
            textBox.WordWrap = false;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 0);
            webView.Margin = new Padding(3, 2, 3, 2);
            webView.Name = "webView";
            webView.Size = new Size(349, 261);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 316);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 12, 0);
            statusStrip.Size = new Size(700, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(62, 17);
            toolStripStatusLabel.Text = "Ln 1, Col 1";
            // 
            // quickAccess
            // 
            quickAccess.ImageScalingSize = new Size(20, 20);
            quickAccess.Items.AddRange(new ToolStripItem[] { newQuickAccessButton, openQuickAccessButton, saveQuickAccessButton, saveAsQuickAccessButton, toolStripSeparator8, cutQuickAccessButton, copyQuickAccessButton, pasteQuickAccessButton, toolStripSeparator7, undoQuickAccessButton, redoQuickAccessButton, toolStripSeparator6, headingToolStripDropDown, boldQuickAccessButton, italicQuickAccessButton, quoteQuickAccessButton, codeQuickAccessButton, linkQuickAccessButton, toolStripSeparator9, bulletListQuickAccessButton, numberedListQuickAccessButton });
            quickAccess.Location = new Point(0, 24);
            quickAccess.Name = "quickAccess";
            quickAccess.Size = new Size(700, 27);
            quickAccess.TabIndex = 3;
            quickAccess.Text = "toolStrip1";
            // 
            // newQuickAccessButton
            // 
            newQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newQuickAccessButton.Image = Properties.Resources._new;
            newQuickAccessButton.ImageTransparentColor = Color.Magenta;
            newQuickAccessButton.Name = "newQuickAccessButton";
            newQuickAccessButton.Size = new Size(24, 24);
            newQuickAccessButton.Text = "New item";
            // 
            // openQuickAccessButton
            // 
            openQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openQuickAccessButton.Image = Properties.Resources.open;
            openQuickAccessButton.ImageTransparentColor = Color.Magenta;
            openQuickAccessButton.Name = "openQuickAccessButton";
            openQuickAccessButton.Size = new Size(24, 24);
            openQuickAccessButton.Text = "Open";
            openQuickAccessButton.ToolTipText = "Open";
            // 
            // saveQuickAccessButton
            // 
            saveQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveQuickAccessButton.Image = Properties.Resources.save;
            saveQuickAccessButton.ImageTransparentColor = Color.Magenta;
            saveQuickAccessButton.Name = "saveQuickAccessButton";
            saveQuickAccessButton.Size = new Size(24, 24);
            saveQuickAccessButton.Text = "Save";
            // 
            // saveAsQuickAccessButton
            // 
            saveAsQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveAsQuickAccessButton.Image = Properties.Resources.save_as;
            saveAsQuickAccessButton.ImageTransparentColor = Color.Magenta;
            saveAsQuickAccessButton.Name = "saveAsQuickAccessButton";
            saveAsQuickAccessButton.Size = new Size(24, 24);
            saveAsQuickAccessButton.Text = "Save as";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 27);
            // 
            // cutQuickAccessButton
            // 
            cutQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutQuickAccessButton.Image = Properties.Resources.cut;
            cutQuickAccessButton.ImageTransparentColor = Color.Magenta;
            cutQuickAccessButton.Name = "cutQuickAccessButton";
            cutQuickAccessButton.Size = new Size(24, 24);
            cutQuickAccessButton.Text = "Cut";
            // 
            // copyQuickAccessButton
            // 
            copyQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyQuickAccessButton.Image = Properties.Resources.copy;
            copyQuickAccessButton.ImageTransparentColor = Color.Magenta;
            copyQuickAccessButton.Name = "copyQuickAccessButton";
            copyQuickAccessButton.Size = new Size(24, 24);
            copyQuickAccessButton.Text = "Copy";
            // 
            // pasteQuickAccessButton
            // 
            pasteQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteQuickAccessButton.Image = Properties.Resources.paste;
            pasteQuickAccessButton.ImageTransparentColor = Color.Magenta;
            pasteQuickAccessButton.Name = "pasteQuickAccessButton";
            pasteQuickAccessButton.Size = new Size(24, 24);
            pasteQuickAccessButton.Text = "Paste";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 27);
            // 
            // undoQuickAccessButton
            // 
            undoQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoQuickAccessButton.Image = Properties.Resources.undo;
            undoQuickAccessButton.ImageTransparentColor = Color.Magenta;
            undoQuickAccessButton.Name = "undoQuickAccessButton";
            undoQuickAccessButton.Size = new Size(24, 24);
            undoQuickAccessButton.Text = "Undo";
            undoQuickAccessButton.ToolTipText = "Undo";
            // 
            // redoQuickAccessButton
            // 
            redoQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoQuickAccessButton.Image = Properties.Resources.redo;
            redoQuickAccessButton.ImageTransparentColor = Color.Magenta;
            redoQuickAccessButton.Name = "redoQuickAccessButton";
            redoQuickAccessButton.Size = new Size(24, 24);
            redoQuickAccessButton.Text = "Redo";
            redoQuickAccessButton.ToolTipText = "Redo";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // headingToolStripDropDown
            // 
            headingToolStripDropDown.DisplayStyle = ToolStripItemDisplayStyle.Image;
            headingToolStripDropDown.DropDownItems.AddRange(new ToolStripItem[] { h1QuickAccessItem, h2QuickAccessItem, h3QuickAccessItem, h4QuickAccessItem, h5QuickAccessItem, h6QuickAccessItem });
            headingToolStripDropDown.Image = Properties.Resources.heading;
            headingToolStripDropDown.ImageTransparentColor = Color.Magenta;
            headingToolStripDropDown.Name = "headingToolStripDropDown";
            headingToolStripDropDown.Size = new Size(33, 24);
            headingToolStripDropDown.Text = "toolStripDropDownButton1";
            headingToolStripDropDown.ToolTipText = "Heading level";
            // 
            // h1QuickAccessItem
            // 
            h1QuickAccessItem.Name = "h1QuickAccessItem";
            h1QuickAccessItem.Size = new Size(89, 22);
            h1QuickAccessItem.Text = "H1";
            // 
            // h2QuickAccessItem
            // 
            h2QuickAccessItem.Name = "h2QuickAccessItem";
            h2QuickAccessItem.Size = new Size(89, 22);
            h2QuickAccessItem.Text = "H2";
            // 
            // h3QuickAccessItem
            // 
            h3QuickAccessItem.Name = "h3QuickAccessItem";
            h3QuickAccessItem.Size = new Size(89, 22);
            h3QuickAccessItem.Text = "H3";
            // 
            // h4QuickAccessItem
            // 
            h4QuickAccessItem.Name = "h4QuickAccessItem";
            h4QuickAccessItem.Size = new Size(89, 22);
            h4QuickAccessItem.Text = "H4";
            // 
            // h5QuickAccessItem
            // 
            h5QuickAccessItem.Name = "h5QuickAccessItem";
            h5QuickAccessItem.Size = new Size(89, 22);
            h5QuickAccessItem.Text = "H5";
            // 
            // h6QuickAccessItem
            // 
            h6QuickAccessItem.Name = "h6QuickAccessItem";
            h6QuickAccessItem.Size = new Size(89, 22);
            h6QuickAccessItem.Text = "H6";
            // 
            // boldQuickAccessButton
            // 
            boldQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldQuickAccessButton.Image = Properties.Resources.bold;
            boldQuickAccessButton.ImageTransparentColor = Color.Magenta;
            boldQuickAccessButton.Name = "boldQuickAccessButton";
            boldQuickAccessButton.Size = new Size(24, 24);
            boldQuickAccessButton.Text = "Bold";
            boldQuickAccessButton.ToolTipText = "Bold";
            // 
            // italicQuickAccessButton
            // 
            italicQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            italicQuickAccessButton.Image = Properties.Resources.italic;
            italicQuickAccessButton.ImageTransparentColor = Color.Magenta;
            italicQuickAccessButton.Name = "italicQuickAccessButton";
            italicQuickAccessButton.Size = new Size(24, 24);
            italicQuickAccessButton.Text = "Italic";
            italicQuickAccessButton.ToolTipText = "Italic";
            // 
            // quoteQuickAccessButton
            // 
            quoteQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            quoteQuickAccessButton.Image = Properties.Resources.quote;
            quoteQuickAccessButton.ImageTransparentColor = Color.Magenta;
            quoteQuickAccessButton.Name = "quoteQuickAccessButton";
            quoteQuickAccessButton.Size = new Size(24, 24);
            quoteQuickAccessButton.Text = "Quote";
            // 
            // codeQuickAccessButton
            // 
            codeQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            codeQuickAccessButton.Image = Properties.Resources.code;
            codeQuickAccessButton.ImageTransparentColor = Color.Magenta;
            codeQuickAccessButton.Name = "codeQuickAccessButton";
            codeQuickAccessButton.Size = new Size(24, 24);
            codeQuickAccessButton.Text = "Code";
            // 
            // linkQuickAccessButton
            // 
            linkQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            linkQuickAccessButton.Image = Properties.Resources.link;
            linkQuickAccessButton.ImageTransparentColor = Color.Magenta;
            linkQuickAccessButton.Name = "linkQuickAccessButton";
            linkQuickAccessButton.Size = new Size(24, 24);
            linkQuickAccessButton.Text = "Link";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 27);
            // 
            // bulletListQuickAccessButton
            // 
            bulletListQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bulletListQuickAccessButton.Image = Properties.Resources.list_ul;
            bulletListQuickAccessButton.ImageTransparentColor = Color.Magenta;
            bulletListQuickAccessButton.Name = "bulletListQuickAccessButton";
            bulletListQuickAccessButton.Size = new Size(24, 24);
            bulletListQuickAccessButton.Text = "Bullet List";
            // 
            // numberedListQuickAccessButton
            // 
            numberedListQuickAccessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            numberedListQuickAccessButton.Image = Properties.Resources.list_ol;
            numberedListQuickAccessButton.ImageTransparentColor = Color.Magenta;
            numberedListQuickAccessButton.Name = "numberedListQuickAccessButton";
            numberedListQuickAccessButton.Size = new Size(24, 24);
            numberedListQuickAccessButton.Text = "Numbered List";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { undoContextMenuItem, redoContextMenuItem, toolStripSeparator10, cutContextMenuItem, copyContextMenuItem, pasteContextMenuItem, toolStripSeparator11, boldContextMenuItem, italicContextMenuItem, codeContextMenuItem, toolStripSeparator13, insertContextMenuStrip, toolStripSeparator12, selectAllContextMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(123, 248);
            // 
            // undoContextMenuItem
            // 
            undoContextMenuItem.Name = "undoContextMenuItem";
            undoContextMenuItem.Size = new Size(122, 22);
            undoContextMenuItem.Text = "Undo";
            // 
            // redoContextMenuItem
            // 
            redoContextMenuItem.Name = "redoContextMenuItem";
            redoContextMenuItem.Size = new Size(122, 22);
            redoContextMenuItem.Text = "Redo";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(119, 6);
            // 
            // cutContextMenuItem
            // 
            cutContextMenuItem.Name = "cutContextMenuItem";
            cutContextMenuItem.Size = new Size(122, 22);
            cutContextMenuItem.Text = "Cut";
            // 
            // copyContextMenuItem
            // 
            copyContextMenuItem.Name = "copyContextMenuItem";
            copyContextMenuItem.Size = new Size(122, 22);
            copyContextMenuItem.Text = "Copy";
            // 
            // pasteContextMenuItem
            // 
            pasteContextMenuItem.Name = "pasteContextMenuItem";
            pasteContextMenuItem.Size = new Size(122, 22);
            pasteContextMenuItem.Text = "Paste";
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(119, 6);
            // 
            // boldContextMenuItem
            // 
            boldContextMenuItem.Name = "boldContextMenuItem";
            boldContextMenuItem.Size = new Size(122, 22);
            boldContextMenuItem.Text = "Bold";
            // 
            // italicContextMenuItem
            // 
            italicContextMenuItem.Name = "italicContextMenuItem";
            italicContextMenuItem.Size = new Size(122, 22);
            italicContextMenuItem.Text = "Italic";
            // 
            // codeContextMenuItem
            // 
            codeContextMenuItem.Name = "codeContextMenuItem";
            codeContextMenuItem.Size = new Size(122, 22);
            codeContextMenuItem.Text = "Code";
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new Size(119, 6);
            // 
            // insertContextMenuStrip
            // 
            insertContextMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { linkContextMenuItem });
            insertContextMenuStrip.Name = "insertContextMenuStrip";
            insertContextMenuStrip.Size = new Size(122, 22);
            insertContextMenuStrip.Text = "Insert";
            // 
            // linkContextMenuItem
            // 
            linkContextMenuItem.Name = "linkContextMenuItem";
            linkContextMenuItem.Size = new Size(96, 22);
            linkContextMenuItem.Text = "Link";
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(119, 6);
            // 
            // selectAllContextMenuItem
            // 
            selectAllContextMenuItem.Name = "selectAllContextMenuItem";
            selectAllContextMenuItem.Size = new Size(122, 22);
            selectAllContextMenuItem.Text = "Select All";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(quickAccess);
            Controls.Add(statusStrip);
            Controls.Add(splitContainer);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MarkEdit";
            Load += MainForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            quickAccess.ResumeLayout(false);
            quickAccess.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem replaceToolStripMenuItem;
        private ToolStripMenuItem goToToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private ExtendedTextBox textBox;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private StatusStrip statusStrip;
        private ToolStrip quickAccess;
        private ToolStripButton boldQuickAccessButton;
        private ToolStripButton undoQuickAccessButton;
        private ToolStripButton redoQuickAccessButton;
        private ToolStripButton italicQuickAccessButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton saveQuickAccessButton;
        private ToolStripButton saveAsQuickAccessButton;
        private ToolStripButton cutQuickAccessButton;
        private ToolStripButton copyQuickAccessButton;
        private ToolStripButton pasteQuickAccessButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton quoteQuickAccessButton;
        private ToolStripButton codeQuickAccessButton;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton linkQuickAccessButton;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripDropDownButton headingToolStripDropDown;
        private ToolStripButton bulletListQuickAccessButton;
        private ToolStripButton numberedListQuickAccessButton;
        private ToolStripButton newQuickAccessButton;
        private ToolStripButton openQuickAccessButton;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem headingToolStripMenuItem;
        private ToolStripMenuItem codeToolStripMenuItem;
        private ToolStripMenuItem h1ToolStripMenuItem;
        private ToolStripMenuItem h2ToolStripMenuItem;
        private ToolStripMenuItem h3ToolStripMenuItem;
        private ToolStripMenuItem h4ToolStripMenuItem;
        private ToolStripMenuItem h5ToolStripMenuItem;
        private ToolStripMenuItem h6ToolStripMenuItem;
        private ToolStripMenuItem h1QuickAccessItem;
        private ToolStripMenuItem h2QuickAccessItem;
        private ToolStripMenuItem h3QuickAccessItem;
        private ToolStripMenuItem h4QuickAccessItem;
        private ToolStripMenuItem h5QuickAccessItem;
        private ToolStripMenuItem h6QuickAccessItem;
        private ToolStripMenuItem linkToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem undoContextMenuItem;
        private ToolStripMenuItem redoContextMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem cutContextMenuItem;
        private ToolStripMenuItem copyContextMenuItem;
        private ToolStripMenuItem pasteContextMenuItem;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem boldContextMenuItem;
        private ToolStripMenuItem italicContextMenuItem;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem selectAllContextMenuItem;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem insertContextMenuStrip;
        private ToolStripMenuItem linkContextMenuItem;
        private ToolStripMenuItem codeContextMenuItem;
        private ToolStripMenuItem listToolStripMenu;
        private ToolStripMenuItem bulletListToolStripMenuItem;
        private ToolStripMenuItem numberedListToolStripMenuItem;
        private ToolStripMenuItem togglePreviewToolStripMenuItem;
        private ToolStripMenuItem toggleSourceViewToolStripMenuItem;
        private ToolStripMenuItem splitViewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator14;
    }
}
