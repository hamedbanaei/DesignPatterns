namespace TemplateMethodPattern
{
    partial class NavigationForm
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.btnCancelUpdate = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.pnlButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Khaki;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.MaximumSize = new System.Drawing.Size(3000, 39);
			this.lblTitle.MinimumSize = new System.Drawing.Size(391, 39);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(391, 39);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "\r\n";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlButtons
			// 
			this.pnlButtons.BackColor = System.Drawing.Color.Khaki;
			this.pnlButtons.Controls.Add(this.btnCancelUpdate);
			this.pnlButtons.Controls.Add(this.btnEdit);
			this.pnlButtons.Controls.Add(this.btnUpdate);
			this.pnlButtons.Controls.Add(this.btnAddNew);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlButtons.Location = new System.Drawing.Point(0, 233);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(391, 29);
			this.pnlButtons.TabIndex = 1;
			// 
			// btnCancelUpdate
			// 
			this.btnCancelUpdate.Location = new System.Drawing.Point(255, 3);
			this.btnCancelUpdate.Name = "btnCancelUpdate";
			this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnCancelUpdate.TabIndex = 2;
			this.btnCancelUpdate.Text = "Cancel";
			this.btnCancelUpdate.UseVisualStyleBackColor = true;
			this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(93, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(174, 3);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(12, 3);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(75, 23);
			this.btnAddNew.TabIndex = 0;
			this.btnAddNew.Text = "Insert";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// NavigationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 262);
			this.Controls.Add(this.pnlButtons);
			this.Controls.Add(this.lblTitle);
			this.Name = "NavigationForm";
			this.Text = "NavigationForm";
			this.Load += new System.EventHandler(this.NavigationForm_Load);
			this.pnlButtons.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlButtons;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnCancelUpdate;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnUpdate;
	}
}