// See https://aka.ms/new-console-template for more information

using System.Configuration.Assemblies;
using Code.cool.Gym;

///Console.WriteLine("Hello, World!");


BodyBuilder Tibi = new BodyBuilder("Tibi", new DateTime(1980,01,01) , Gender.male);
BodyBuilder Lilla = new BodyBuilder("Lilla", new DateTime(1990,01,01) , Gender.female);

Wallet _wallet = new Wallet(1200);
Wallet _walletLilla = new Wallet(990);
Tibi.MyWallet = _wallet;
Lilla.MyWallet = _walletLilla

// Tibi.TicketsOfThisGuy.Add(new MonthTicket(DateTime.Now));
Gym gym = new Gym();

gym.BuyTicket(Tibi, TicketType.day);
gym.BuyTicket(Lilla, TicketType.day);

gym.Enter(Tibi);
// gym.Enter(Laci);
// gym.CheckOut(Tibi);
Console.Clear();
Console.WriteLine(gym);