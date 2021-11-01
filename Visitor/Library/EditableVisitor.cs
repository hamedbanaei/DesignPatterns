namespace Library
{
	internal static class EditableVisitor
	{
		internal static void EffectAfterEnter(System.Windows.Forms.Control control, System.EventArgs e)
		{
			control.ForeColor = System.Drawing.Color.Red;
			control.BackColor = System.Drawing.Color.Yellow;

			control.Font =
				new System.Drawing.Font
					(control.Font.Name, control.Font.Size, System.Drawing.FontStyle.Bold);
		}

		internal static void EffectAfterLeave(System.Windows.Forms.Control control, System.EventArgs e)
		{
			control.BackColor = System.Drawing.SystemColors.Window;
			control.ForeColor = System.Drawing.SystemColors.WindowText;

			control.Font =
				new System.Drawing.Font
					(control.Font.Name, control.Font.Size, System.Drawing.FontStyle.Regular);
		}
	}
}
