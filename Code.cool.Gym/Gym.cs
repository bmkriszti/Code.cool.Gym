namespace Code.cool.Gym;

public class Gym
{
    private const int _limit = 30;
    private List<Person> _builders;
    private const int Ticket = 1000;
    private const int MonthTicketCost = 20000;
    public Gym()
    {
        _builders = new List<Person>();
    }

    public void Enter(Person person)
    {
        if (person is Employee)
        {
            return;
        }
        if (person.TicketsOfThisGuy.Count > 0)
        {
            foreach (var ticket in person.TicketsOfThisGuy)
            {
             if (ticket.isValid())
             {
                 _builders.Add(person);
                  
                   return;
             }
         }
            
        }
        HandleByTicket(person);
    }

    
    
    private void HandleByTicket(Person person)
    {
        if (_builders.Count < _limit && person is BodyBuilder)
        {
            if (DateTime.Today.Year - person.BirthDate.Year < 14) // Subtract(person.BirthDate).TotalDays > 14*365
            {
                throw new Exception("Under the expected age.");
            }

            if (person.MyWallet != null)
            {
                if (person.GenderType == Gender.male)
                {
                    if (person.MyWallet.TryPay(Ticket) == 0.0m)
                    {
                        throw new Exception("Not enough money, loser -Male!");
                    }
                }

                if (person.GenderType == Gender.female)
                {
                    if (person.MyWallet.TryPay(Ticket* 0.9m) == 0.0m)
                    {
                        throw new Exception("Not enough money, loser -Female!");
                    }
                }

            }

            _builders.Add(person);
        }
    }

    public void BuyTicket(Person person, TicketType type)
    {
        if (type == TicketType.day && person.MyWallet.TryPay(Ticket) != 0.0m)
        {
            person.TicketsOfThisGuy.Add(new DayTicket());
            return;
        }

        if (type == TicketType.month && person.MyWallet.TryPay(MonthTicketCost) != 0.0m)
        {
            person.TicketsOfThisGuy.Add(new MonthTicket(DateTime.Now));
            return;
        }
        throw new Exception("BuyTicket method error");
    }
    public void CheckOut(Person person)
    {
        if (_builders.Contains(person))
        {
            _builders.Remove(person);
        }
        else
        {
            Console.WriteLine("Person not found!");
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