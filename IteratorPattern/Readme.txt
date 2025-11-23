Iterator: An object (or, in .NET, a method) that facilitates the traversal of a data structure
		without exposing its underlying representation.

Motivation:
- Iteration (Traversal) is a core functionality of various data structures like lists, trees, and graphs.
- An iterator is a class that facilitates the traversal
	- Keeps a reference to the current element (Provides access to the current element)
	- Knows how to move to the next element
- Iterator is an implicit construct
	- .NET builds a state machine around your yield return statements
