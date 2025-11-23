namespace BuilderFacets;

public class PersonAddressBuilder : PersonBuilder
{
    // Not work with a value type! For them you sould pass them trought refrence.
    public PersonAddressBuilder(Person person)
    {
        Person = person;
    }

    public PersonAddressBuilder At(string streetAddress)
    {
        Person.StreetAddress = streetAddress;
        return this;
    }

    public PersonAddressBuilder WithPostcode(string postcode)
    {
        Person.Postcode = postcode;
        return this;
    }

    public PersonAddressBuilder In(string city)
    {
        Person.City = city;
        return this;
    }
}
