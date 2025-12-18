// high-level modules should not depend on low-level ones; both should depend on abstractions
// abstractions should not depend on details; details should depend on abstractions

using DependencyInversionPrinciple;

var parent = new Person { Name = "Kourosh" };
var child1 = new Person { Name = "Bardia" };
var child2 = new Person { Name = "Atoosa" };

// low-level module
var relationships = new Relationships();
relationships.AddParentAndChild(parent, child1);
relationships.AddParentAndChild(parent, child2);

new Research(relationships);