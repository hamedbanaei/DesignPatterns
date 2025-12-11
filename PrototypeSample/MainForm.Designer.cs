namespace PrototypeSample;

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
        pnlButtons = new System.Windows.Forms.Panel();
        btnAddLabel = new System.Windows.Forms.Button();
        pnlMain = new System.Windows.Forms.Panel();
        btnClear = new System.Windows.Forms.Button();
        pnlButtons.SuspendLayout();
        SuspendLayout();
        // 
        // pnlButtons
        // 
        pnlButtons.Controls.Add(btnClear);
        pnlButtons.Controls.Add(btnAddLabel);
        pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
        pnlButtons.Location = new System.Drawing.Point(0, 0);
        pnlButtons.Name = "pnlButtons";
        pnlButtons.Size = new System.Drawing.Size(800, 74);
        pnlButtons.TabIndex = 0;
        // 
        // btnAddLabel
        // 
        btnAddLabel.Location = new System.Drawing.Point(12, 12);
        btnAddLabel.Name = "btnAddLabel";
        btnAddLabel.Size = new System.Drawing.Size(150, 46);
        btnAddLabel.TabIndex = 0;
        btnAddLabel.Text = "Add Label";
        btnAddLabel.UseVisualStyleBackColor = true;
        btnAddLabel.Click += btnAddLabel_Click;
        // 
        // pnlMain
        // 
        pnlMain.BackColor = System.Drawing.Color.Khaki;
        pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
        pnlMain.Location = new System.Drawing.Point(0, 74);
        pnlMain.Name = "pnlMain";
        pnlMain.Size = new System.Drawing.Size(800, 376);
        pnlMain.TabIndex = 0;
        // 
        // btnClear
        // 
        btnClear.Location = new System.Drawing.Point(168, 12);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(150, 46);
        btnClear.TabIndex = 1;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(pnlMain);
        Controls.Add(pnlButtons);
        Name = "MainForm";
        Text = "Main Form";
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;
        pnlButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel pnlButtons;
    private System.Windows.Forms.Button btnAddLabel;
    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.Button btnClear;
}
