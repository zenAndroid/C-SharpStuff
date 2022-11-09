using static System.Console;
internal class Program
{
    /// <summary>
    /// Yep, it should be pretty obvious ...
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    static double Add(double a, double b)
    {
        return a + b; // deliberate bug!
    }
    private static void Main(string[] args)
    {
        double a = 475.5;
        double b = 2.5;
        double answer = Add(a, b);
        WriteLine($"{a} + {b} = {answer}");
        WriteLine("Press ENTER to end the app.");
        ReadLine(); // wait for user to press ENTER
    }
}