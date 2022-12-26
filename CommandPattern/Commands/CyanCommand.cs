namespace CommandPattern.Commands
{
	public class CyanCommand : Command
	{
		public CyanCommand()
		{
		}

		public override void Execute()
		{
			if (Form != null)
			{
				Form.Text = "CyanCommand has been executed!";
				Form.BackColor = System.Drawing.Color.Cyan;
			}
		}
	}
}
