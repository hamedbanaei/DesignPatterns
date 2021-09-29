namespace StrategyPattern
{
	public class Person : System.Object
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public void TellAboutYourself()
		{
			string strAbout = $"FirstName: {FirstName},\t\tLastName: {LastName}";
			System.Console.WriteLine(strAbout);
		}
	}
}
