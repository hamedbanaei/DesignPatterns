// See https://aka.ms/new-console-template for more information
using StrategyPattern;

System.Collections.Generic.List<Person> lstPersons =
				new System.Collections.Generic.List<Person>();

lstPersons.Add(new Person { FirstName = "Hamed", LastName = "Banaei" });
lstPersons.Add(new Person { FirstName = "Youtab", LastName = "Hakha" });
lstPersons.Add(new Person { FirstName = "Ario", LastName = "Barzan", });
lstPersons.Add(new Person { FirstName = "Kourosh", LastName = "Irani" });
lstPersons.Add(new Person { FirstName = "Dariush", LastName = "Parsi" });

System.Console.WriteLine("We are testing with the following list:");
foreach (Person item in lstPersons)
{
	item.TellAboutYourself();
}
System.Console.WriteLine(System.Environment.NewLine);

System.Console.WriteLine("Sorting list ascendingly with FirstName:");
FirstNameSorter oFirstNameAscendingSortAlgorithm = new FirstNameSorter() { SortOrder = SortOrder.Ascending };
lstPersons.Sort(oFirstNameAscendingSortAlgorithm);
foreach (Person item in lstPersons)
{
	item.TellAboutYourself();
}
System.Console.WriteLine(System.Environment.NewLine);

System.Console.WriteLine("Sorting list descendingly with LastName:");
LastNameSorter oLastNameDescendingSortAlgorithm = new LastNameSorter() { SortOrder = SortOrder.Descending };
lstPersons.Sort(oLastNameDescendingSortAlgorithm);
foreach (Person item in lstPersons)
{
	item.TellAboutYourself();
}
System.Console.WriteLine(System.Environment.NewLine);
System.Console.ReadLine();