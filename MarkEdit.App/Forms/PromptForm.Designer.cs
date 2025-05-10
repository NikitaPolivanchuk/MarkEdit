using System.ComponentModel;

namespace MarkEdit.App.Forms;

partial class PromptForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        textLabel = new System.Windows.Forms.Label();
        textbox = new System.Windows.Forms.TextBox();
        acceptButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textLabel
        // 
        textLabel.Location = new System.Drawing.Point(12, 9);
        textLabel.Name = "textLabel";
        textLabel.Size = new System.Drawing.Size(360, 25);
        textLabel.TabIndex = 0;
        textLabel.Text = "Promt text";
        textLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // textbox
        // 
        textbox.Location = new System.Drawing.Point(12, 37);
        textbox.Name = "textbox";
        textbox.Size = new System.Drawing.Size(360, 23);
        textbox.TabIndex = 1;
        // 
        // acceptButton
        // 
        acceptButton.Location = new System.Drawing.Point(292, 79);
        acceptButton.Name = "acceptButton";
        acceptButton.Size = new System.Drawing.Size(80, 25);
        acceptButton.TabIndex = 2;
        acceptButton.Text = "OK";
        acceptButton.UseVisualStyleBackColor = true;
        // 
        // PromptForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(384, 111);
        Controls.Add(acceptButton);
        Controls.Add(textbox);
        Controls.Add(textLabel);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Prompt";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button acceptButton;

    private System.Windows.Forms.TextBox textbox;

    private System.Windows.Forms.Label textLabel;

    #endregion
}