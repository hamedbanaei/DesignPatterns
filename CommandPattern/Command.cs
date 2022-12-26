namespace CommandPattern
{
	public abstract class Command : System.ComponentModel.Component, ICommand
	{
		public System.Windows.Forms.Form Form { get; set; }

		#region ICommand Members
		public abstract void Execute();
		#endregion
	}
}
