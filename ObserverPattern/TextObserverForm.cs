namespace ObserverPattern;

public partial class TextObserverForm : System.Windows.Forms.Form, IObserver
{
    public TextObserverForm()
    {
        InitializeComponent();
    }

	public TextObserverForm(ISubject subject)
			: this()
	{
		MySubject = subject;
		MySubject.Register(this);
	}

	protected ISubject MySubject { get; set; }

	public void Notify(Message message)
	{
		lstData.Items.Add(message.Text);
	}

	private void TextObserverForm_FormClosing
		(object sender, System.Windows.Forms.FormClosingEventArgs e)
	{
		MySubject.Unregister(this);
	}
}
