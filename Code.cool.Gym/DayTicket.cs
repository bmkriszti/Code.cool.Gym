namespace Code.cool.Gym;

public class DayTicket : Ticket
{
    private int _count = 0;

    public override bool isValid()
    {
        if (_count == 0)
        {
            return true;
        }
        _count++;
        return false;
    }
}