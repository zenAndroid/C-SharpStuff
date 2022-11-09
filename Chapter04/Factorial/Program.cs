
class Program
{
    /// <summary>
    /// Ah shit
    /// </summary>
    /// <param name="number">A number</param>
    /// <returns></returns>
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
    private static void Main(string[] args)
    {
        Console.WriteLine(Factorial(15));
        Console.WriteLine(CardinalToOrdinal(45));
        RunFactorial();
    }
    /// <summary>
    /// Calculates factorials
    /// </summary>
    /// <param name="number">The number whose factorial we want</param>
    /// <returns>Ok, so apparently this auto-generated XML doc business only woorks for methods and not top-level functions ...
    /// Jesus christ that would have been good to know <b>BEFORE</b> wasting time trying to figure the old one out, so much for ,, ugh whatever</returns>
    static ulong Factorial(ulong number)
    {
        if (number < 0)
        {
            return 0;
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }
    }
    /// <summary>
    /// <i>Sigh</i>
    /// </summary>
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
}