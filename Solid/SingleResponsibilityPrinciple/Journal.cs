namespace SingleResponsibilityPrinciple;

/// <summary>
/// just stores a couple of journal entries and ways of working with them
/// <summary>
public class Journal
{
	private readonly List<string> entries = new List<string>();

	public void AddEntry(string text)
	{
		entries.Add(text);
	}

	public void RemoveEntry(int index)
	{
		entries.RemoveAt(index);
	}

	public override string ToString()
	{
		return string.Join(Environment.NewLine, entries);
	}

	// breaks single responsibility principle
	//public void Save(string filename, bool overwrite = false)
	//{
	//	File.WriteAllText(filename, ToString());
	//}

	// breaks single responsibility principle
	//public void Load(string filename)
	//{

	//}

	// breaks single responsibility principle
	//public void Load(Uri uri)
	//{

	//}
}
