var j = new SingleResponsibilityPrinciple.Journal();
j.AddEntry("I cried today.");
j.AddEntry("I ate a bug.");
System.Console.WriteLine(j);

var p = new SingleResponsibilityPrinciple.Persistence();
var filename = @"c:\temp\journal.txt";
p.SaveToFile(j, filename);
System.Diagnostics.Process.Start(filename);
