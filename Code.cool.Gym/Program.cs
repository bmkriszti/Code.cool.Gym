// See https://aka.ms/new-console-template for more information

using System.Configuration.Assemblies;
using Code.cool.Gym;

///Console.WriteLine("Hello, World!");

BodyBuilder Tibi = new BodyBuilder("Tibi", DateTime.Today, Gender.male);

Gym gym = new Gym();

gym.Enter(Tibi);

Console.Clear();
Console.WriteLine(gym);