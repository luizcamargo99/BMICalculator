namespace BMICalculator;

public class Calculator
{
    private const int SQUARED = 2;
    public double Calculate(float weight, float height) => RoundResultToTwoDigits(weight / Math.Pow(height, SQUARED));
    private double RoundResultToTwoDigits(double result) => Math.Round(result, 2);
}
