
namespace ProxyPatternSample
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
			this.picPicture = new System.Windows.Forms.PictureBox();
			this.btnShowImage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// picPicture
			// 
			this.picPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picPicture.Location = new System.Drawing.Point(12, 12);
			this.picPicture.Name = "picPicture";
			this.picPicture.Size = new System.Drawing.Size(468, 583);
			this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picPicture.TabIndex = 0;
			this.picPicture.TabStop = false;
			// 
			// btnShowImage
			// 
			this.btnShowImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShowImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnShowImage.Location = new System.Drawing.Point(12, 601);
			this.btnShowImage.Name = "btnShowImage";
			this.btnShowImage.Size = new System.Drawing.Size(468, 23);
			this.btnShowImage.TabIndex = 1;
			this.btnShowImage.Text = "Show Image";
			this.btnShowImage.UseVisualStyleBackColor = true;
			this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 636);
			this.Controls.Add(this.btnShowImage);
			this.Controls.Add(this.picPicture);
			this.Name = "MainForm";
			this.Text = "Proxy Pattern Sample";
			((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picPicture;
		private System.Windows.Forms.Button btnShowImage;
	}
}

