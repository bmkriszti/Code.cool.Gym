namespace Code.cool.Gym;

public class Wallet
{
    private decimal _balance;

    public Wallet(decimal baseMoney)
    {
        _balance = baseMoney;
    }

    public decimal TryPay(decimal ticketPrice)
    {
        if (_balance > ticketPrice)
        {
            _balance = _balance - ticketPrice;
            return _balance;
        }
        else
        {
            return 0.0m;
        }
    }

}