using IteratorPattern;

// Create collection
var library = new BookCollection();

// Add books
library.AddBook(new Book("Clean Code"));
library.AddBook(new Book("Design Patterns"));
library.AddBook(new Book("Refactoring"));
library.AddBook(new Book("System Design"));

// Create iterator
IIterator<Book> iterator =
	library.CreateIterator();

// Traverse collection
while (iterator.HasNext())
{
	Book book = iterator.Next();

	Console.WriteLine(book.Title);
}