namespace CommandProject
{
	public partial class CommandPatternSampleForm : System.Windows.Forms.Form
	{
		public CommandPatternSampleForm()
		{
			InitializeComponent();
		}

		private void ExecuteCommand(object sender, System.EventArgs e)
		{
			ICommandHolder xCommand = (ICommandHolder)sender;
			xCommand.Command.Execute();
		}
	}
}
