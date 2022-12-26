namespace CommandPattern.Commands
{
	public class RedCommand : Command
	{
		public RedCommand()
		{
		}

		public override void Execute()
		{
			if (Form != null)
			{
				Form.Text = "RedCommand has been executed!";
				Form.BackColor = System.Drawing.Color.Red;
			}
		}
	}
}
