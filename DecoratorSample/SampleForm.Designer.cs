namespace DecoratorSample
{
    partial class SampleForm
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
            picPicture1 = new Hbx.Windows.Forms.PictureBox();
            picPicture2 = new Hbx.Windows.Forms.PictureBox();
            picPicture3 = new Hbx.Windows.Forms.PictureBox();
            picPicture4 = new Hbx.Windows.Forms.PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)picPicture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPicture2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPicture3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPicture4).BeginInit();
            SuspendLayout();
            // 
            // picPicture1
            // 
            picPicture1.Image = Properties.Resources.Monster;
            picPicture1.Location = new Point(24, 23);
            picPicture1.Margin = new Padding(6);
            picPicture1.Name = "picPicture1";
            picPicture1.Size = new Size(396, 329);
            picPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picPicture1.TabIndex = 0;
            picPicture1.TabStop = false;
            // 
            // picPicture2
            // 
            picPicture2.Image = Properties.Resources.Monster;
            picPicture2.Location = new Point(432, 23);
            picPicture2.Margin = new Padding(6);
            picPicture2.Name = "picPicture2";
            picPicture2.Size = new Size(396, 329);
            picPicture2.SizeMode = PictureBoxSizeMode.StretchImage;
            picPicture2.TabIndex = 1;
            picPicture2.TabStop = false;
            // 
            // picPicture3
            // 
            picPicture3.Image = Properties.Resources.Monster;
            picPicture3.Location = new Point(24, 364);
            picPicture3.Margin = new Padding(6);
            picPicture3.Name = "picPicture3";
            picPicture3.Size = new Size(396, 329);
            picPicture3.SizeMode = PictureBoxSizeMode.StretchImage;
            picPicture3.TabIndex = 2;
            picPicture3.TabStop = false;
            // 
            // picPicture4
            // 
            picPicture4.Image = Properties.Resources.Monster;
            picPicture4.Location = new Point(432, 364);
            picPicture4.Margin = new Padding(6);
            picPicture4.Name = "picPicture4";
            picPicture4.Size = new Size(396, 329);
            picPicture4.SizeMode = PictureBoxSizeMode.StretchImage;
            picPicture4.TabIndex = 3;
            picPicture4.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(837, 23);
            button1.Name = "button1";
            button1.Size = new Size(210, 183);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1053, 23);
            button2.Name = "button2";
            button2.Size = new Size(210, 183);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(837, 212);
            button3.Name = "button3";
            button3.Size = new Size(210, 183);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1053, 212);
            button4.Name = "button4";
            button4.Size = new Size(210, 183);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // SampleForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 738);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(picPicture4);
            Controls.Add(picPicture3);
            Controls.Add(picPicture2);
            Controls.Add(picPicture1);
            Name = "SampleForm";
            Text = "Sample";
            Load += SampleForm_Load;
            ((System.ComponentModel.ISupportInitialize)picPicture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPicture2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPicture3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPicture4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Hbx.Windows.Forms.PictureBox picPicture1;
        private Hbx.Windows.Forms.PictureBox picPicture2;
        private Hbx.Windows.Forms.PictureBox picPicture3;
        private Hbx.Windows.Forms.PictureBox picPicture4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
