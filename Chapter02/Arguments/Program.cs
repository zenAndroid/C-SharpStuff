using static System.Console;

WriteLine($"There are {args.Length} arguments.");

// 0 args before fucking with args, 4 after passing in :firstarg second-arg third:arg "fourth arg":, WOW

// i should stop fucking around, death approaches and i am wasting time
foreach (string arg in args)
{
    WriteLine(arg);
}

/*
There are 4 arguments.
firstarg
second-arg
third:arg
fourth arg
*/

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // stop running
}
ForegroundColor = (ConsoleColor)Enum.Parse(
enumType: typeof(ConsoleColor),
value: args[0],
ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(
enumType: typeof(ConsoleColor), value: args[1],
ignoreCase: true);
CursorSize = int.Parse(args[2]);