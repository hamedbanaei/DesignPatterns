namespace IteratorPattern;

public interface IIterator<T>
{
	// Checks whether another element exists.
	bool HasNext();

	// Returns the next element.
	T Next();
}
