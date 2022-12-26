namespace CommandPattern
{
	public class CommandButton : System.Windows.Forms.Button, ICommandHolder
	{
		#region ICommandHolder Members
		private ICommand _command;
		public ICommand Command
		{
			get
			{
				return (_command);
			}
			set
			{
				_command = value;
			}
		}
		#endregion
	}
}
