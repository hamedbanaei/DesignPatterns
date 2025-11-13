namespace SingleResponsibilityPrinciple;

/// <summary>
/// handles the responsibility of persisting objects
/// </summary>
public class Persistence
{
	public void SaveToFile(Journal journal, string filename, bool overwrite = false)
	{
		if (overwrite || !File.Exists(filename))
			File.WriteAllText(filename, journal.ToString());
	}
}
