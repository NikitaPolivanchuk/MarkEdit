namespace MarkEdit.App.Controls;

partial class SearchReplaceControl
{
    private System.Windows.Forms.TextBox searchTextbox;
    private System.Windows.Forms.TextBox replaceTextbox;
    private System.Windows.Forms.Button showNextButton;
    private System.Windows.Forms.Button showPreviousButton;
    private System.Windows.Forms.Button replaceButton;
    private System.Windows.Forms.Button replaceAllButton;
    private System.Windows.Forms.Button toggleReplaceButton;
    private System.Windows.Forms.Button closeButton;

    private void InitializeComponent()
    {
        searchTextbox = new TextBox();
        replaceTextbox = new TextBox();
        showNextButton = new Button();
        showPreviousButton = new Button();
        replaceButton = new Button();
        replaceAllButton = new Button();
        toggleReplaceButton = new Button();
        closeButton = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        replacePanel = new TableLayoutPanel();
        tableLayoutPanel4 = new TableLayoutPanel();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        replacePanel.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        SuspendLayout();
        // 
        // searchTextbox
        // 
        searchTextbox.Dock = DockStyle.Fill;
        searchTextbox.Location = new Point(3, 3);
        searchTextbox.Name = "searchTextbox";
        searchTextbox.PlaceholderText = "Find";
        searchTextbox.Size = new Size(623, 23);
        searchTextbox.TabIndex = 0;
        searchTextbox.TextChanged += SearchTextbox_TextChanged;
        // 
        // replaceTextbox
        // 
        replaceTextbox.Dock = DockStyle.Fill;
        replaceTextbox.Location = new Point(3, 3);
        replaceTextbox.Name = "replaceTextbox";
        replaceTextbox.PlaceholderText = "Replace";
        replaceTextbox.Size = new Size(548, 23);
        replaceTextbox.TabIndex = 0;
        // 
        // showNextButton
        // 
        showNextButton.Location = new Point(632, 3);
        showNextButton.Name = "showNextButton";
        showNextButton.Size = new Size(23, 23);
        showNextButton.TabIndex = 1;
        showNextButton.Text = "↓";
        showNextButton.Click += ShowNextButton_Click;
        // 
        // showPreviousButton
        // 
        showPreviousButton.Location = new Point(661, 3);
        showPreviousButton.Name = "showPreviousButton";
        showPreviousButton.Size = new Size(23, 23);
        showPreviousButton.TabIndex = 2;
        showPreviousButton.Text = "↑";
        showPreviousButton.Click += ShowPreviousButton_Click;
        // 
        // replaceButton
        // 
        replaceButton.Location = new Point(557, 3);
        replaceButton.Name = "replaceButton";
        replaceButton.Size = new Size(75, 23);
        replaceButton.TabIndex = 1;
        replaceButton.Text = "Replace";
        replaceButton.Click += ReplaceButton_Click;
        // 
        // replaceAllButton
        // 
        replaceAllButton.Location = new Point(638, 3);
        replaceAllButton.Name = "replaceAllButton";
        replaceAllButton.Size = new Size(75, 23);
        replaceAllButton.TabIndex = 2;
        replaceAllButton.Text = "Replace All";
        replaceAllButton.Click += ReplaceAllButton_Click;
        // 
        // toggleReplaceButton
        // 
        toggleReplaceButton.Location = new Point(3, 3);
        toggleReplaceButton.Name = "toggleReplaceButton";
        toggleReplaceButton.Size = new Size(23, 23);
        toggleReplaceButton.TabIndex = 3;
        toggleReplaceButton.Text = "▲";
        toggleReplaceButton.Click += ToggleReplaceButton_Click;
        // 
        // closeButton
        // 
        closeButton.Location = new Point(690, 3);
        closeButton.Name = "closeButton";
        closeButton.Size = new Size(23, 23);
        closeButton.TabIndex = 4;
        closeButton.Text = "✖";
        closeButton.Click += CloseButton_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoScroll = true;
        tableLayoutPanel1.ColumnCount = 5;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(closeButton, 4, 0);
        tableLayoutPanel1.Controls.Add(showPreviousButton, 3, 0);
        tableLayoutPanel1.Controls.Add(showNextButton, 2, 0);
        tableLayoutPanel1.Controls.Add(searchTextbox, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Top;
        tableLayoutPanel1.Location = new Point(39, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
        tableLayoutPanel1.Size = new Size(716, 30);
        tableLayoutPanel1.TabIndex = 6;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.AutoSize = true;
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 0);
        tableLayoutPanel2.Controls.Add(replacePanel, 1, 1);
        tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Top;
        tableLayoutPanel2.Location = new Point(0, 0);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.RowStyles.Add(new RowStyle());
        tableLayoutPanel2.Size = new Size(758, 72);
        tableLayoutPanel2.TabIndex = 7;
        // 
        // replacePanel
        // 
        replacePanel.ColumnCount = 3;
        replacePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        replacePanel.ColumnStyles.Add(new ColumnStyle());
        replacePanel.ColumnStyles.Add(new ColumnStyle());
        replacePanel.Controls.Add(replaceAllButton, 2, 0);
        replacePanel.Controls.Add(replaceButton, 1, 0);
        replacePanel.Controls.Add(replaceTextbox, 0, 0);
        replacePanel.Dock = DockStyle.Top;
        replacePanel.Location = new Point(39, 39);
        replacePanel.Name = "replacePanel";
        replacePanel.RowCount = 1;
        replacePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        replacePanel.Size = new Size(716, 30);
        replacePanel.TabIndex = 7;
        replacePanel.Visible = false;
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Controls.Add(toggleReplaceButton, 0, 0);
        tableLayoutPanel4.Location = new Point(3, 3);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 1;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel4.Size = new Size(30, 30);
        tableLayoutPanel4.TabIndex = 8;
        // 
        // SearchReplaceControl
        // 
        AutoSize = true;
        BackColor = SystemColors.Control;
        BorderStyle = BorderStyle.FixedSingle;
        Controls.Add(tableLayoutPanel2);
        MinimumSize = new Size(200, 30);
        Name = "SearchReplaceControl";
        Size = new Size(758, 73);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        tableLayoutPanel2.ResumeLayout(false);
        replacePanel.ResumeLayout(false);
        replacePanel.PerformLayout();
        tableLayoutPanel4.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel replacePanel;
    private TableLayoutPanel tableLayoutPanel4;
}