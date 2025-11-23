namespace BuilderFacets;

public class Person
{
    #region Address Properties
    public string StreetAddress { get; set; }

    public string Postcode { get; set; }

    public string City { get; set; }
    #endregion /Address Properties


    #region Employment Properties
    public string CompanyName { get; set; }

    public string Position { get; set; }

    public int AnnualIncome { get; set; }
    #endregion /Employment Properties


    public override string ToString()
    {
        return 
            $"{nameof(StreetAddress)}: {StreetAddress}\r\n" +
            $"{nameof(Postcode)}: {Postcode}\r\n" +
            $"{nameof(City)}: {City}\r\n" +
            $"{nameof(CompanyName)}: {CompanyName}\r\n" +
            $"{nameof(Position)}: {Position}\r\n" +
            $"{nameof(AnnualIncome)}: {AnnualIncome}";
    }
}
