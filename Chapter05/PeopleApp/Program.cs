using Packt.Shared;
using zenLib;
using zenLib.Shared;
using static System.Console;

Person bob = new();
WriteLine(bob.ToString());

bob.Name = "Amine Zen";
bob.Dob= DateTime.Now;

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
arg0: bob.Name,
arg1: bob.Dob);

bob.FavoriteWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;


Person zen = new() { Name = "Zen", Dob = new(1997, 8, 7) };

WriteLine(zen.Origin);
WriteLine(zen.Age);
WriteLine(zen.Greeting);

object[] passengers = {
new FirstClassPassenger { AirMiles = 1_419 },
new FirstClassPassenger { AirMiles = 16_562 },
new BusinessClassPassenger(),
new CoachClassPassenger { CarryOnKG = 25.7 },
new CoachClassPassenger { CarryOnKG = 0 },
};
foreach (object passenger in passengers)
{
    /*decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };*/
    decimal flightCost = passenger switch
    {
        /* C# 8 syntax
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger => 2000M, */
        // C# 9 or later syntax
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _ => 2000M
        },
        BusinessClassPassenger => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}