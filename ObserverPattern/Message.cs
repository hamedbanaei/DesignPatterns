namespace ObserverPattern;

public class Message : System.Object
{
	public Message()
	{
		Text = string.Empty;
	}

	public Message(string text)
		: this()
	{
		Text = text;
	}

	public string Text { get; set; }
}
