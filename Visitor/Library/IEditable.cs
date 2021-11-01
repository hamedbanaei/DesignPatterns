namespace Library
{
	internal interface IEditable
	{
		void OnAfterEnter(System.EventArgs e);
		void OnAfterLeave(System.EventArgs e);

		System.Drawing.Font Font { get; set; }
		System.Drawing.Color ForeColor { get; set; }
		System.Drawing.Color BackColor { get; set; }
	}
}
