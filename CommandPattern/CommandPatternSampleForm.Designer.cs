namespace CommandPattern
{
    partial class CommandPatternSampleForm
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRedCommand = new CommandPattern.CommandButton();
			this.myRedCommand = new CommandPattern.Commands.RedCommand();
			this.btnKhakiCommand = new CommandPattern.CommandButton();
			this.myKhakiCommand = new CommandPattern.Commands.KhakiCommand();
			this.btnCyanCommand = new CommandPattern.CommandButton();
			this.myCyanCommand = new CommandPattern.Commands.CyanCommand();
			this.SuspendLayout();
			// 
			// btnRedCommand
			// 
			this.btnRedCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnRedCommand.Command = this.myRedCommand;
			this.btnRedCommand.Location = new System.Drawing.Point(12, 12);
			this.btnRedCommand.Name = "btnRedCommand";
			this.btnRedCommand.Size = new System.Drawing.Size(539, 23);
			this.btnRedCommand.TabIndex = 0;
			this.btnRedCommand.Text = "Red Command";
			this.btnRedCommand.UseVisualStyleBackColor = true;
			this.btnRedCommand.Click += new System.EventHandler(this.ExecuteCommand);
			// 
			// myRedCommand
			// 
			this.myRedCommand.Form = this;
			// 
			// btnKhakiCommand
			// 
			this.btnKhakiCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnKhakiCommand.Command = this.myKhakiCommand;
			this.btnKhakiCommand.Location = new System.Drawing.Point(12, 70);
			this.btnKhakiCommand.Name = "btnKhakiCommand";
			this.btnKhakiCommand.Size = new System.Drawing.Size(539, 23);
			this.btnKhakiCommand.TabIndex = 1;
			this.btnKhakiCommand.Text = "Khaki Command";
			this.btnKhakiCommand.UseVisualStyleBackColor = true;
			this.btnKhakiCommand.Click += new System.EventHandler(this.ExecuteCommand);
			// 
			// myKhakiCommand
			// 
			this.myKhakiCommand.Form = this;
			// 
			// btnCyanCommand
			// 
			this.btnCyanCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnCyanCommand.Command = this.myCyanCommand;
			this.btnCyanCommand.Location = new System.Drawing.Point(12, 41);
			this.btnCyanCommand.Name = "btnCyanCommand";
			this.btnCyanCommand.Size = new System.Drawing.Size(539, 23);
			this.btnCyanCommand.TabIndex = 2;
			this.btnCyanCommand.Text = "Cyan Command";
			this.btnCyanCommand.UseVisualStyleBackColor = true;
			this.btnCyanCommand.Click += new System.EventHandler(this.ExecuteCommand);
			// 
			// myCyanCommand
			// 
			this.myCyanCommand.Form = this;
			// 
			// CommandPatternSampleForm
			// 
			this.ClientSize = new System.Drawing.Size(563, 240);
			this.Controls.Add(this.btnCyanCommand);
			this.Controls.Add(this.btnKhakiCommand);
			this.Controls.Add(this.btnRedCommand);
			this.Name = "CommandPatternSampleForm";
			this.ResumeLayout(false);

		}

		#endregion

		private CommandButton btnRedCommand;
		private CommandButton btnKhakiCommand;
		private CommandButton btnCyanCommand;
		private Commands.CyanCommand myCyanCommand;
		private Commands.KhakiCommand myKhakiCommand;
		private Commands.RedCommand myRedCommand;
	}
}