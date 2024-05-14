namespace Code.cool.Gym;

public class Gym
{
    private const int _limit = 30;
    private List<Person> _builders;

    public Gym()
    {
        _builders = new List<Person>();
    }

    public void Enter(Person person)
    {
        if (_builders.Count < _limit && person is BodyBuilder)
        {
            _builders.Add(person);
        }
    }

    public override string ToString()
    {
       string result = string.Empty;
       foreach (var p in _builders)
       { 
           result += p.Name;
           result += Environment.NewLine;
       }
       return result;
    }
}