using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisitorPatternSample
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm frmMain = new MainForm();
			Application.Run(frmMain);
			if (frmMain.IsDisposed==false)
			{
				frmMain.Dispose();
			}
			frmMain = null;
		}
	}
}
