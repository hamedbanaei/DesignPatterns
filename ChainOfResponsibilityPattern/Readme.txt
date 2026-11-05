Chain of Responsibility Design Pattern
The Chain of Responsibility is a behavioral design pattern
that allows a request to pass through a chain of handlers.
Each handler decides whether to process the request itself,
pass it to the next handler, or both.

The main goal is to decouple the sender of a request from the object that handles it.

Our sample scenario
Imagine an employee requesting leave from a company.

The approval process depends on the number of requested days:
- Team Leader: Can approve up to 2 days.
- Department Manager: Can approve up to 5 days.
- General Manager: Can approve up to 10 days.
- If nobody can approve the request, it gets rejected.
Instead of writing multiple if-else statements, we create a chain of responsibility.
