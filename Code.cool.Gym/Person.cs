namespace Code.cool.Gym;

public class Person
{
    public string Name { get; }
    public DateTime BirthDate { get; }
    public Gender GenderType { get; }

    public Person(string name, DateTime birthDate, Gender genderType)
    {
        Name = name;
        BirthDate = birthDate;
        GenderType = genderType;
    }
    
    
}