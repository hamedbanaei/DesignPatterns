// ********** ********** ********** ********** **********
// Life Without Builder
// ********** ********** ********** ********** **********

//System.Console.WriteLine("Life Without Builder is like:");

//// if you want to build a simple HTML paragraph using StringBuilder
//string hello = "Hello";
//var sb = new System.Text.StringBuilder();
//sb.Append("<p>");
//sb.Append(hello);
//sb.Append("</p>");
//System.Console.WriteLine(sb);
//System.Console.WriteLine(System.Environment.NewLine);


//// now I want an HTML list with some words in it
//var words = new[] { "Hello", "Wise", "Students" };
//sb.Clear();
//sb.Append("<ul>");
//foreach (var item in words)
//{
//    sb.Append($"<li>{item}</li>");

//}
//sb.Append("</ul>");
//System.Console.WriteLine(sb);
//System.Console.WriteLine(System.Environment.NewLine);

// ********** ********** ********** ********** **********
// / Life Without Builder
// ********** ********** ********** ********** **********



// ********** ********** ********** ********** **********
// Simple Builder
// ********** ********** ********** ********** **********

//System.Console.WriteLine("Ordinary non-fluent Builder is like:");
//// Ordinary non-fluent Builder
//var builder = new SimpleBuilder.HtmlBuilder("ul");
//builder.AddChild("li", "hello");
//builder.AddChild("li", "world");
//System.Console.WriteLine(builder.ToString());
//System.Console.WriteLine(System.Environment.NewLine);

// ********** ********** ********** ********** **********
// / Simple Builder
// ********** ********** ********** ********** **********



// ********** ********** ********** ********** **********
// Life Without Builder
// ********** ********** ********** ********** **********

var me = Rgi.Person.New
        .Called("Hamed")
        .WorksAsA("CTO")
        .Born(DateTime.UtcNow)
        .Build();

Console.WriteLine(me);

// ********** ********** ********** ********** **********
// Life Without Builder
// ********** ********** ********** ********** **********