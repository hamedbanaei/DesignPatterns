namespace PrototypeSample;

internal static class Program
{
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[System.STAThread]
	static void Main()
	{
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();

		using MainForm frmMain = new MainForm();
		System.Windows.Forms.Application.Run(frmMain);
	}
}
