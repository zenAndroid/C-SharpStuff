using System.Diagnostics.Metrics;
using System.Xml;
    
object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");
// int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");


// storing a string in a dynamic object
// string has a Length property
dynamic something = "Ahmed";
// int does not have a Length property
something = 12;
// an array of any type has a Length property
something = new[] { 3, 5, 7 };

Console.WriteLine(something.Length);

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument();
// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");

/*
Amir is 1.88 metres tall.
Amir has 4 characters.
3
default(int) = 0
default(bool) = False
default(DateTime) = 0001 - 01 - 01 12:00:00 AM
default(string) =
number has been set to: 13
number has been reset to its default: 0
*/