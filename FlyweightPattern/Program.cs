// ********** ********** ********** ********** **********
// Client Uses Flyweight Pattern
// ********** ********** ********** ********** **********

var factory = new TreeTypeFactory();

// درخت بلوط
var oak = factory.GetTreeType(
	name: "Oak",
	color: "Green",
	texture: "OakTexture" 
);

// درخت کاج
var pine = factory.GetTreeType(
	name: "Pine",
	color: "DarkGreen",
	texture: "PineTexture"
);



// Creating multiple trees
var forest = new List<Tree>
		{
			new(10, 20, 12, oak),
			new(30, 50, 15, oak),
			new(70, 10, 10, oak),

			new(100, 40, 20, pine),
			new(120, 70, 25, pine),
			new(150, 90, 18, pine)
		};


WriteLine();
WriteLine("    Forest Simulation");
WriteLine("============================");

foreach (var tree in forest)
{
	tree.Draw();
}


WriteLine();
WriteLine($"Number of Tree Objects: {forest.Count}");
WriteLine($"Number of TreeType Objects: {factory.Count}");

// ********** ********** ********** ********** **********
// / Client Uses Flyweight Pattern
// ********** ********** ********** ********** **********