//Now it's comming to use it ...

System.Data.IDbConnection oConnection = null;
System.Data.IDbCommand oCommand = null;

try
{
	oConnection =
        FactoryMethodPattern.ConnectionFactory.GetConnection();

	oCommand =
        FactoryMethodPattern.CommandFactory.GetCommand(oConnection);

    // Now use oConnection and oCommand and remember:
    // To immigrate to another DBMS
    // Simply use pure T-Sql and
    // Change Provider key in config!

    Console.WriteLine($"Connection String is: [{oConnection.ConnectionString}]");
    Console.WriteLine($"Selected Provider in Confige File is: [{FactoryMethodPattern.ApplicationSettings.MyProvider}]");
    Console.WriteLine($"Connection Type: [{oConnection.GetType().Name}]");
    Console.WriteLine($"Command Type: [{oCommand.GetType().Name}]");
}
catch (System.Exception ex)
{
	System.Console.WriteLine(ex.Message);
}