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