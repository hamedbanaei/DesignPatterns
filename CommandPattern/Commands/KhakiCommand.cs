namespace CommandPattern.Commands
{
	public class KhakiCommand : Command
	{
		public KhakiCommand()
		{
		}

		public override void Execute()
		{
			if (Form != null)
			{
				Form.Text = "KhakiCommand has been executed!";
				Form.BackColor = System.Drawing.Color.Khaki;
			}
		}
	}
}
