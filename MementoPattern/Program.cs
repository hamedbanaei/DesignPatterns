// ********** ********** ********** ********** **********
// Simple Memento
// ********** ********** ********** ********** **********

var ba = new SimpleMemento.BankAccount(100); // Balance = 100
var m1 = ba.Deposit(50); // Balance = 150
var m2 = ba.Deposit(25); // Balance = 175
System.Console.WriteLine(ba);

// Restore to m1
ba.Restore(m1);
System.Console.WriteLine(ba);

// Restore to m2
ba.Restore(m2);
System.Console.WriteLine(ba);

// ********** ********** ********** ********** **********
// Simple Memento
// ********** ********** ********** ********** **********



// ********** ********** ********** ********** **********
// Memento with Undo and Redo
// ********** ********** ********** ********** **********

//var ba = new MementoWithUndoRedo.BankAccount(100);
//ba.Deposit(50);
//ba.Deposit(25);
//System.Console.WriteLine(ba);

//ba.Undo();
//System.Console.WriteLine($"Undo 1: {ba}");

//ba.Undo();
//System.Console.WriteLine($"Undo 2: {ba}");

//ba.Redo();
//System.Console.WriteLine($"Redo 1: {ba}");

// ********** ********** ********** ********** **********
// / Memento with Undo and Redo
// ********** ********** ********** ********** **********