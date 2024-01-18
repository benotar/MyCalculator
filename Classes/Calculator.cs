namespace MyCalculator.Classes;

public static class Calculator
{
    public static void Action()
    {
        CalculatorInfo calculator = new CalculatorInfo();
        try
        {
            Console.WriteLine("Welcome to my Calculator version 1.0");

            Console.WriteLine("====================================\n");

            Console.Write("First number: ");
            if (!double.TryParse(Console.ReadLine(), out double left))
            {
                Console.WriteLine("You must enter a number!");
                return;
            }

            Console.Write("Operations: ");
            if (!char.TryParse(Console.ReadLine(), out char operations) || char.IsDigit(operations))
            {
                Console.WriteLine("You must enter a character!");
                return;
            }

            Console.Write("Second number: ");
            if (!double.TryParse(Console.ReadLine(), out double right))
            {
                Console.WriteLine("You must enter a number!");
                return;
            }

            Console.WriteLine($"Result: {calculator.Calculate(left, right, operations)}");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}