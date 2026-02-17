using Microsoft.VisualBasic;

namespace ObserverPattern;

public partial class SubjectForm : System.Windows.Forms.Form, ISubject
{
	public SubjectForm()
	{
		InitializeComponent();
	}

	private void SubjectForm_Load(object sender, System.EventArgs e)
	{
		TextObserverForm frm;

		int intLeft = 25;

		for (int intIndex = 0; intIndex < 5; intIndex++)
		{
			frm = new TextObserverForm(this);
			
			frm.Top = 25;
			frm.Left = intLeft + (intIndex * frm.Width);
			frm.StartPosition = FormStartPosition.Manual;
			
			frm.Show();
		}

		txtData.Focus();
	}

	private System.Collections.Generic.List<IObserver> _myObservers;
	protected System.Collections.Generic.List<IObserver> MyObservers
	{
		get
		{
			if (_myObservers == null)
			{
				_myObservers =
					new System.Collections.Generic.List<IObserver>();
			}
			return _myObservers;
		}
	}

	public void Register(IObserver observer)
	{
		MyObservers.Add(observer);
	}

	public void Unregister(IObserver observer)
	{
		MyObservers.Remove(observer);
	}

	public void NotifyObservers(Message message)
	{
		foreach (IObserver oObserver in MyObservers)
		{
			oObserver.Notify(message);
		}
	}

	private void txtData_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
	{
		if (e.KeyChar == 13)
		{
			Message oMessage =
				new Message(txtData.Text);

			NotifyObservers(oMessage);

			txtData.SelectAll();
		}
	}
}
