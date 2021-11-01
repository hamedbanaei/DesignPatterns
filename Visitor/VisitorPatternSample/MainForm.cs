using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPatternSample
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 1;
			comboBox2.SelectedIndex = 1;

			MessageBox.Show("Simply navigate between controls to see what happens!","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
