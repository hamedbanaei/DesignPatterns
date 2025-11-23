namespace BuilderFacets;

// Facade
public class PersonBuilder
{
    // The object we're going to build
    protected Person Person = new Person(); // This is a reference type!

    public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);

    public PersonJobBuilder Works => new PersonJobBuilder(Person);

    public static implicit operator Person(PersonBuilder pb)
    {
        return pb.Person;
    }
}
