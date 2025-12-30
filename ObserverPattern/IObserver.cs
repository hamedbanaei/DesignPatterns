namespace ObserverPattern;

public interface IObserver
{
	void Notify(Message message);
}
