


static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11: // special cases for 11th to 13th
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}


static ulong Factorial(ulong number)
{
    if (number < 0)
    {
        return 0;
    } else if (number == 0)
    {
        return 1;
    } else
    {
        checked
        {
            return number * Factorial(number - 1); 
        }
    }
}

Console.WriteLine(Factorial(15));
Console.WriteLine(CardinalToOrdinal(45));

static void RunFactorial()
{
    for (ulong i = 1; i < 25; i++)
    {
        try
        {
            Console.WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"{i}! is too big for a `ulong`!");
        }
    }
}

RunFactorial();