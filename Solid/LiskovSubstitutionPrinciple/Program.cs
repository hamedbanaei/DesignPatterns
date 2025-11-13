using LiskovSubstitutionPrinciple;

Rectangle rc = new Rectangle(2, 3);
System.Console.WriteLine($"{rc} has area {MathOperations.Area(rc)}");

// LSP says:
// should be able to substitute a base type for a subtype

// Square
Rectangle sq = new Square();
sq.Width = 4;
System.Console.WriteLine($"{sq} has area {MathOperations.Area(sq)}");
