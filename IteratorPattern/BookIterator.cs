namespace IteratorPattern;

/// <summary>
/// Notice that the iterator manages the current position.
/// The collection doesn't need to know anything about traversal.
/// </summary>
public class BookIterator : IIterator<Book>
{
	private readonly List<Book> _books;

	private int _position = 0;

	public BookIterator(List<Book> books)
	{
		_books = books;
	}

	public bool HasNext()
	{
		return _position < _books.Count;
	}

	public Book Next()
	{
		if (HasNext() == false)
		{
			throw new InvalidOperationException
				("No more books available.");
		}

		return _books[_position++];
	}
}
