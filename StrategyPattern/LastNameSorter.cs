namespace StrategyPattern
{
	public class LastNameSorter : System.Collections.Generic.IComparer<Person>
	{
		public LastNameSorter()
		{
			SortOrder = SortOrder.Ascending;
		}

		public LastNameSorter(SortOrder sortOrder)
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
					return (string.Compare(x.LastName.ToLower(), y.LastName.ToLower()));
				}
				else
				{
					return (string.Compare(y.LastName.ToLower(), x.LastName.ToLower()));
				}
			}
		}
	}
}
