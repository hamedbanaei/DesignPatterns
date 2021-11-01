namespace Library
{
	public class TextBox : System.Windows.Forms.TextBox
	{
		public TextBox()
		{
		}

		protected override void OnEnter(System.EventArgs e)
		{
			base.OnEnter(e);

			ForeColor = System.Drawing.Color.Red;
			BackColor = System.Drawing.Color.Yellow;

			Font =
				new System.Drawing.Font
					(Font.Name, Font.Size, System.Drawing.FontStyle.Bold);
		}

		protected override void OnLeave(System.EventArgs e)
		{
			base.OnLeave(e);

			BackColor = System.Drawing.SystemColors.Window;
			ForeColor = System.Drawing.SystemColors.WindowText;

			Font =
				new System.Drawing.Font
					(Font.Name, Font.Size, System.Drawing.FontStyle.Regular);
		}
	}
}
