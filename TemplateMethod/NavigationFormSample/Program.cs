using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationFormSample
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

			EmployeeForm frmEmployee = new EmployeeForm();
			Application.Run(frmEmployee);
			if (frmEmployee.IsDisposed == false)
			{
				frmEmployee.Dispose();
			}
			frmEmployee = null;
		}
	}
}
