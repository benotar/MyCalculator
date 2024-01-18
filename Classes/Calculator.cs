namespace MyCalculator.Classes;

public class Calculator
{
    private readonly CalculatorOperations _calculator;

    public Calculator()
    {
        _calculator = new CalculatorOperations();
    }

    public double Calculate(double left, double right, char operations)
    {
        var operationFunc = GetOperationFunction(operations);
        return Temp(left, right, operationFunc);
    }

    private double Temp(double left, double right, Func<double, double, double> action)
    {
        return action.Invoke(left, right);
    }

    private Func<double, double, double> GetOperationFunction(char operation)
    {
        return operation switch
        {
            '+' => _calculator.Addition,
            '-' => _calculator.Subtraction,
            '*' => _calculator.Multiplication,
            '/' => _calculator.Division,
            _ => throw new ArgumentException("Invalid operation!", nameof(operation)),
        };
    }
}
