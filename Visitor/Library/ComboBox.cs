namespace Library
{
	public class ComboBox : System.Windows.Forms.ComboBox, IEditable
	{
		public ComboBox()
		{
		}

		protected override void OnEnter(System.EventArgs e)
		{
			base.OnEnter(e);
			OnAfterEnter(e);
		}

		protected override void OnLeave(System.EventArgs e)
		{
			base.OnLeave(e);
			OnAfterLeave(e);
		}

		public void OnAfterEnter(System.EventArgs e)
		{
			EditableVisitor.EffectAfterEnter(this, e);
		}

		public void OnAfterLeave(System.EventArgs e)
		{
			EditableVisitor.EffectAfterLeave(this, e);
		}
	}
}
