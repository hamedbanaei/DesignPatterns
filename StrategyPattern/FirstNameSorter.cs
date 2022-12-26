namespace StrategyPattern
{
	public class FirstNameSorter : System.Collections.Generic.IComparer<Person>
	{
		public FirstNameSorter()
		{
			SortOrder = SortOrder.Ascending;
		}

		public FirstNameSorter(SortOrder sortOrder)
		{
			SortOrder = sortOrder;
		}

		public SortOrder SortOrder { get; set; }

		public int Compare(Person x, Person y)
		{
			if (x == null || y == null)
			{
				return (0);
			}
			else
			{
				if (SortOrder == SortOrder.Ascending)
				{
					return (string.Compare(x.FirstName.ToLower(), y.FirstName.ToLower()));
				}
				else
				{
					return (string.Compare(y.FirstName.ToLower(), x.FirstName.ToLower()));
				}
			}
		}
	}
}
