
namespace VisitorPatternSample
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.textBox1 = new Library.TextBox();
			this.textBox2 = new Library.TextBox();
			this.comboBox1 = new Library.ComboBox();
			this.comboBox2 = new Library.ComboBox();
			this.listBox1 = new Library.ListBox();
			this.listBox2 = new Library.ListBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(496, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Some Text";
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.Location = new System.Drawing.Point(12, 38);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(496, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Some Text";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item"});
			this.comboBox1.Location = new System.Drawing.Point(12, 64);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(496, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// comboBox2
			// 
			this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item"});
			this.comboBox2.Location = new System.Drawing.Point(12, 91);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(496, 21);
			this.comboBox2.TabIndex = 5;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item"});
			this.listBox1.Location = new System.Drawing.Point(12, 124);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(496, 108);
			this.listBox1.TabIndex = 6;
			// 
			// listBox2
			// 
			this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Items.AddRange(new object[] {
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item",
            "Some Item"});
			this.listBox2.Location = new System.Drawing.Point(12, 247);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(496, 108);
			this.listBox2.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 376);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Visitor Pattern Sample";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Library.TextBox textBox1;
		private Library.TextBox textBox2;
		private Library.ComboBox comboBox1;
		private Library.ComboBox comboBox2;
		private Library.ListBox listBox1;
		private Library.ListBox listBox2;
	}
}

