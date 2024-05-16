namespace Code.cool.Gym;

public class MonthTicket : Ticket
{
    public DateTime _boughtTime { get; private set; }

    public MonthTicket(DateTime boughtTime)
    {
        _boughtTime = boughtTime;
    }

    public override bool isValid()
    {
        if (_boughtTime.Year == DateTime.Today.Year && _boughtTime.Month <= DateTime.Today.Month &&
            _boughtTime.Day <= DateTime.Today.Day)
        {
            return true;
        }
        return false;
    }

}