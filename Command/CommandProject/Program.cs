using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandProject
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			CommandPatternSampleForm frm = new CommandPatternSampleForm();
			Application.Run(frm);
			if (frm.IsDisposed==false)
			{
				frm.Dispose();
			}
			frm = null;
		}
	}
}
