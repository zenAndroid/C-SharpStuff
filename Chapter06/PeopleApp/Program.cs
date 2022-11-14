using Packt.Shared;
using System.Linq;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };
// call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";
// call static method
Person baby2 = Person.Procreate(harry, jill);

// call an operator
Person baby3 = harry * mary;

WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");
WriteLine(format: "{0}'s first child is named \"{1}\".",
            arg0: harry.Name,
            arg1: harry.Children[0].Name);

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

Console.WriteLine("----------------------------------");

System.Collections.Hashtable lookupObject = new();

lookupObject.Add(key: 'j', value: "Alpha");
lookupObject.Add(key: "but", value: "Science");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

var key = "but"; // lookup the value that has 2 as its key
WriteLine(format: "Key `{0}` has value: {1}",
arg0: key,
arg1: lookupObject[key]);

// lookup the value that has harry as its key
WriteLine(format: "Key {0} has value: {1}",
arg0: harry,
arg1: lookupObject[harry]);