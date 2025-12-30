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

		for (int intIndex = 0; intIndex < 9; intIndex++)
		{
			frm = new TextObserverForm(this);
			frm.Show();
		}
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
