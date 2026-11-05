namespace IteratorPattern;

/// <summary>
/// The collection is responsible for holding books
/// and 
/// creating an appropriate iterator.
/// </summary>
public class BookCollection : IAggregate<Book>
{
	private readonly List<Book> _books = new();

	public void AddBook(Book book)
	{
		_books.Add(book);
	}

	public IIterator<Book> CreateIterator()
	{
		return new BookIterator(_books);
	}
}
