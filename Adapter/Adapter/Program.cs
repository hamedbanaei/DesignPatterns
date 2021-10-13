namespace AdapterPatternSimpleExample
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[System.STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.SetHighDpiMode(System.Windows.Forms.HighDpiMode.SystemAware);
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

			MainForm frmMain = new MainForm();
			System.Windows.Forms.Application.Run(frmMain);
			if (frmMain.IsDisposed == false)
			{
				frmMain.Dispose();
			}
			frmMain = null;
		}
	}
}
