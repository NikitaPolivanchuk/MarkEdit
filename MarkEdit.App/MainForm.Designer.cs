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
            menuStrip1 = new MenuStrip();
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
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            restoreToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            textBox1 = new ExtendedTextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            saveToolStripButton = new ToolStripButton();
            saveAsToolStripButton = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            undoToolStripButton = new ToolStripButton();
            redoToolStripButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            boldToolStripButton = new ToolStripButton();
            italicToolStripButton = new ToolStripButton();
            quoteToolStripButton = new ToolStripButton();
            codeToolStripButton = new ToolStripButton();
            headerToolStripDropDown = new ToolStripDropDownButton();
            toolStripSeparator9 = new ToolStripSeparator();
            linkToolStripButton = new ToolStripButton();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            splitContainer1.Location = new Point(0, 42);
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
            splitContainer1.Size = new Size(700, 277);
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
            textBox1.Size = new Size(347, 277);
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
            webView21.Size = new Size(349, 277);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(700, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(62, 17);
            toolStripStatusLabel.Text = "Ln 1, Col 1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripButton, saveAsToolStripButton, toolStripSeparator8, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator7, undoToolStripButton, redoToolStripButton, toolStripSeparator6, boldToolStripButton, italicToolStripButton, quoteToolStripButton, codeToolStripButton, headerToolStripDropDown, toolStripSeparator9, linkToolStripButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = Properties.Resources.save;
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(24, 24);
            saveToolStripButton.Text = "Save";
            // 
            // saveAsToolStripButton
            // 
            saveAsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveAsToolStripButton.Image = Properties.Resources.save_as;
            saveAsToolStripButton.ImageTransparentColor = Color.Magenta;
            saveAsToolStripButton.Name = "saveAsToolStripButton";
            saveAsToolStripButton.Size = new Size(24, 24);
            saveAsToolStripButton.Text = "Save as";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 27);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = Properties.Resources.cut;
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(24, 24);
            cutToolStripButton.Text = "Cut";
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = Properties.Resources.copy;
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(24, 24);
            copyToolStripButton.Text = "Copy";
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = Properties.Resources.paste;
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(24, 24);
            pasteToolStripButton.Text = "Paste";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 27);
            // 
            // undoToolStripButton
            // 
            undoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoToolStripButton.Image = Properties.Resources.undo;
            undoToolStripButton.ImageTransparentColor = Color.Magenta;
            undoToolStripButton.Name = "undoToolStripButton";
            undoToolStripButton.Size = new Size(24, 24);
            undoToolStripButton.Text = "Undo";
            undoToolStripButton.ToolTipText = "Undo";
            // 
            // redoToolStripButton
            // 
            redoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoToolStripButton.Image = Properties.Resources.redo;
            redoToolStripButton.ImageTransparentColor = Color.Magenta;
            redoToolStripButton.Name = "redoToolStripButton";
            redoToolStripButton.Size = new Size(24, 24);
            redoToolStripButton.Text = "Redo";
            redoToolStripButton.ToolTipText = "Redo";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // boldToolStripButton
            // 
            boldToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldToolStripButton.Image = Properties.Resources.bold;
            boldToolStripButton.ImageTransparentColor = Color.Magenta;
            boldToolStripButton.Name = "boldToolStripButton";
            boldToolStripButton.Size = new Size(24, 24);
            boldToolStripButton.Text = "Bold";
            boldToolStripButton.ToolTipText = "Bold";
            // 
            // italicToolStripButton
            // 
            italicToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            italicToolStripButton.Image = Properties.Resources.italic;
            italicToolStripButton.ImageTransparentColor = Color.Magenta;
            italicToolStripButton.Name = "italicToolStripButton";
            italicToolStripButton.Size = new Size(24, 24);
            italicToolStripButton.Text = "Italic";
            italicToolStripButton.ToolTipText = "Italic";
            // 
            // quoteToolStripButton
            // 
            quoteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            quoteToolStripButton.Image = Properties.Resources.quote;
            quoteToolStripButton.ImageTransparentColor = Color.Magenta;
            quoteToolStripButton.Name = "quoteToolStripButton";
            quoteToolStripButton.Size = new Size(24, 24);
            quoteToolStripButton.Text = "Quote";
            // 
            // codeToolStripButton
            // 
            codeToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            codeToolStripButton.Image = Properties.Resources.code;
            codeToolStripButton.ImageTransparentColor = Color.Magenta;
            codeToolStripButton.Name = "codeToolStripButton";
            codeToolStripButton.Size = new Size(24, 24);
            codeToolStripButton.Text = "Code";
            // 
            // headerToolStripDropDown
            // 
            headerToolStripDropDown.DisplayStyle = ToolStripItemDisplayStyle.None;
            headerToolStripDropDown.Image = Properties.Resources.bold;
            headerToolStripDropDown.ImageTransparentColor = Color.Magenta;
            headerToolStripDropDown.Name = "headerToolStripDropDown";
            headerToolStripDropDown.Size = new Size(13, 24);
            headerToolStripDropDown.Text = "toolStripDropDownButton1";
            headerToolStripDropDown.ToolTipText = "Header level";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 27);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MarkEdit";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
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
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton boldToolStripButton;
        private ToolStripButton undoToolStripButton;
        private ToolStripButton redoToolStripButton;
        private ToolStripButton italicToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton saveAsToolStripButton;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton quoteToolStripButton;
        private ToolStripButton codeToolStripButton;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton linkToolStripButton;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripDropDownButton headerToolStripDropDown;
    }
}
