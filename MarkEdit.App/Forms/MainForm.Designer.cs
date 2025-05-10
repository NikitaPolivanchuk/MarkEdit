using MarkEdit.App.Controls;

namespace MarkEdit.App
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            toolStripSeparator10 = new ToolStripSeparator();
            insertToolStripMenuItem = new ToolStripMenuItem();
            linkToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            blockquoteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            restoreToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            inlineCodeToolStripMenuItem = new ToolStripMenuItem();
            headingToolStripMenuItem = new ToolStripMenuItem();
            h1ToolStripMenuItem = new ToolStripMenuItem();
            h2ToolStripMenuItem = new ToolStripMenuItem();
            h3ToolStripMenuItem = new ToolStripMenuItem();
            h4ToolStripMenuItem = new ToolStripMenuItem();
            h5ToolStripMenuItem = new ToolStripMenuItem();
            h6ToolStripMenuItem = new ToolStripMenuItem();
            bulletToolStripMenuItem = new ToolStripMenuItem();
            numberedListToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            textBox1 = new ExtendedTextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
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
            linkToolStripButton = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            statusStrip.SuspendLayout();
            quickAccess.SuspendLayout();
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
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, findToolStripMenuItem, replaceToolStripMenuItem, goToToolStripMenuItem, toolStripSeparator10, insertToolStripMenuItem, toolStripSeparator2, selectAllToolStripMenuItem });
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
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(141, 6);
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { linkToolStripMenuItem, imageToolStripMenuItem, blockquoteToolStripMenuItem });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(144, 22);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // linkToolStripMenuItem
            // 
            linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            linkToolStripMenuItem.Size = new Size(134, 22);
            linkToolStripMenuItem.Text = "Link";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(134, 22);
            imageToolStripMenuItem.Text = "Image";
            // 
            // blockquoteToolStripMenuItem
            // 
            blockquoteToolStripMenuItem.Name = "blockquoteToolStripMenuItem";
            blockquoteToolStripMenuItem.Size = new Size(134, 22);
            blockquoteToolStripMenuItem.Text = "Blockquote";
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
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, toolStripSeparator5, restoreToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(106, 22);
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
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { boldToolStripMenuItem, italicToolStripMenuItem, inlineCodeToolStripMenuItem, headingToolStripMenuItem, bulletToolStripMenuItem, numberedListToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "F&ormat";
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            boldToolStripMenuItem.Size = new Size(200, 22);
            boldToolStripMenuItem.Text = "Bold";
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            italicToolStripMenuItem.Size = new Size(200, 22);
            italicToolStripMenuItem.Text = "Italic";
            // 
            // inlineCodeToolStripMenuItem
            // 
            inlineCodeToolStripMenuItem.Name = "inlineCodeToolStripMenuItem";
            inlineCodeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oem3;
            inlineCodeToolStripMenuItem.Size = new Size(200, 22);
            inlineCodeToolStripMenuItem.Text = "Inline Code";
            // 
            // headingToolStripMenuItem
            // 
            headingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { h1ToolStripMenuItem, h2ToolStripMenuItem, h3ToolStripMenuItem, h4ToolStripMenuItem, h5ToolStripMenuItem, h6ToolStripMenuItem });
            headingToolStripMenuItem.Name = "headingToolStripMenuItem";
            headingToolStripMenuItem.Size = new Size(200, 22);
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
            // bulletToolStripMenuItem
            // 
            bulletToolStripMenuItem.Name = "bulletToolStripMenuItem";
            bulletToolStripMenuItem.Size = new Size(200, 22);
            bulletToolStripMenuItem.Text = "Bullet List";
            // 
            // numberedListToolStripMenuItem
            // 
            numberedListToolStripMenuItem.Name = "numberedListToolStripMenuItem";
            numberedListToolStripMenuItem.Size = new Size(200, 22);
            numberedListToolStripMenuItem.Text = "Numbered List";
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
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(0, 53);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(textBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(webView21);
            splitContainer1.Size = new Size(700, 261);
            splitContainer1.SplitterDistance = 347;
            splitContainer1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(347, 261);
            textBox1.TabIndex = 0;
            textBox1.WordWrap = false;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Margin = new Padding(3, 2, 3, 2);
            webView21.Name = "webView21";
            webView21.Size = new Size(349, 261);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
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
            quickAccess.Items.AddRange(new ToolStripItem[] { newQuickAccessButton, openQuickAccessButton, saveQuickAccessButton, saveAsQuickAccessButton, toolStripSeparator8, cutQuickAccessButton, copyQuickAccessButton, pasteQuickAccessButton, toolStripSeparator7, undoQuickAccessButton, redoQuickAccessButton, toolStripSeparator6, headingToolStripDropDown, boldQuickAccessButton, italicQuickAccessButton, quoteQuickAccessButton, codeQuickAccessButton, linkToolStripButton, toolStripSeparator9, toolStripButton1, toolStripButton2 });
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
            // linkToolStripButton
            // 
            linkToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            linkToolStripButton.Image = Properties.Resources.link;
            linkToolStripButton.ImageTransparentColor = Color.Magenta;
            linkToolStripButton.Name = "linkToolStripButton";
            linkToolStripButton.Size = new Size(24, 24);
            linkToolStripButton.Text = "Link";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.list_ul;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(24, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.list_ol;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(24, 24);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(quickAccess);
            Controls.Add(statusStrip);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MarkEdit";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            quickAccess.ResumeLayout(false);
            quickAccess.PerformLayout();
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
        private SplitContainer splitContainer1;
        private ExtendedTextBox textBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
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
        private ToolStripButton linkToolStripButton;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripDropDownButton headingToolStripDropDown;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton newQuickAccessButton;
        private ToolStripButton openQuickAccessButton;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem headingToolStripMenuItem;
        private ToolStripMenuItem bulletToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem linkToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem blockquoteToolStripMenuItem;
        private ToolStripMenuItem inlineCodeToolStripMenuItem;
        private ToolStripMenuItem numberedListToolStripMenuItem;
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
    }
}
