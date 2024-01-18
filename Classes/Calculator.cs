using MyCalculator.Interfaces;

namespace MyCalculator.Classes;

public class Calculator : ICalculator
{
    public double Addition(double left, double right)
       => left + right;


    public double Subtraction(double left, double right)
    => left - right;

    public double Multiplication(double left, double right)
    => left * right;



    public double Division(double left, double right)
    {
        if(right is 0)
        {
            throw new ArgumentException("You cannot divide by zero", nameof(right));
        }

        return left / right;
    }

}
