namespace Code.cool.Gym;

public class Person
{
    public string Name { get; }
    public DateTime BirthDate { get; }
    public Gender GenderType { get; }
    
    public Wallet MyWallet { get; set; }

    public List<Ticket> TicketsOfThisGuy { get; set; }

    public Person(string name, DateTime birthDate, Gender genderType)
    {
        Name = name;
        BirthDate = birthDate;
        GenderType = genderType;
        TicketsOfThisGuy = new List<Ticket>();
    }

    public override bool Equals(Object o)
    {
        Person p = (Person) o;
        return this.Name == p.Name;
    }

}