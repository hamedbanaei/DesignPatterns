namespace AdapterPattern
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
			this.myFileListBoxAdapter = new AdapterPattern.FileListBoxAdapter();
			this.myFileListViewAdapter = new AdapterPattern.FileListViewAdapter();
			this.myFileTreeViewAdapter = new AdapterPattern.FileTreeViewAdapter();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lstFiles = new System.Windows.Forms.ListBox();
			this.tvFiles = new System.Windows.Forms.TreeView();
			this.lvFiles = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// myFileListBoxAdapter
			// 
			this.myFileListBoxAdapter.MyListBox = this.lstFiles;
			// 
			// myFileListViewAdapter
			// 
			this.myFileListViewAdapter.MyListView = this.lvFiles;
			// 
			// myFileTreeViewAdapter
			// 
			this.myFileTreeViewAdapter.MyTreeView = this.tvFiles;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(12, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(502, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add some content with the aid of Adapter Pattern";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(12, 41);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(502, 23);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear content with the aid of Adapter Pattern";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lstFiles
			// 
			this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lstFiles.FormattingEnabled = true;
			this.lstFiles.Location = new System.Drawing.Point(12, 70);
			this.lstFiles.Name = "lstFiles";
			this.lstFiles.Size = new System.Drawing.Size(502, 95);
			this.lstFiles.TabIndex = 2;
			// 
			// tvFiles
			// 
			this.tvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tvFiles.Location = new System.Drawing.Point(12, 171);
			this.tvFiles.Name = "tvFiles";
			this.tvFiles.Size = new System.Drawing.Size(502, 97);
			this.tvFiles.TabIndex = 3;
			// 
			// lvFiles
			// 
			this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lvFiles.FullRowSelect = true;
			this.lvFiles.GridLines = true;
			this.lvFiles.HideSelection = false;
			this.lvFiles.Location = new System.Drawing.Point(12, 274);
			this.lvFiles.MultiSelect = false;
			this.lvFiles.Name = "lvFiles";
			this.lvFiles.Size = new System.Drawing.Size(502, 97);
			this.lvFiles.TabIndex = 4;
			this.lvFiles.UseCompatibleStateImageBehavior = false;
			this.lvFiles.View = System.Windows.Forms.View.Details;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 383);
			this.Controls.Add(this.lvFiles);
			this.Controls.Add(this.tvFiles);
			this.Controls.Add(this.lstFiles);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAdd);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adapter Pattern Simple Example";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private FileListBoxAdapter myFileListBoxAdapter;
		private FileListViewAdapter myFileListViewAdapter;
		private FileTreeViewAdapter myFileTreeViewAdapter;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.ListBox lstFiles;
		private System.Windows.Forms.TreeView tvFiles;
		private System.Windows.Forms.ListView lvFiles;
	}
}