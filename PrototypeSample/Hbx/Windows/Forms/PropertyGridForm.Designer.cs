namespace PrototypeSample.Hbx.Windows.Forms
{
    partial class PropertyGridForm
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
            myPropertyGrid = new System.Windows.Forms.PropertyGrid();
            SuspendLayout();
            // 
            // myPropertyGrid
            // 
            myPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            myPropertyGrid.Location = new System.Drawing.Point(0, 0);
            myPropertyGrid.Name = "myPropertyGrid";
            myPropertyGrid.Size = new System.Drawing.Size(480, 815);
            myPropertyGrid.TabIndex = 0;
            // 
            // PropertyGridForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 815);
            Controls.Add(myPropertyGrid);
            Name = "PropertyGridForm";
            Text = "Property Grid";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PropertyGrid myPropertyGrid;
    }
}