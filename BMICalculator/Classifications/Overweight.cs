namespace BMICalculator.Classifications;

public class Overweight : Classification
{
    public override string Description
    {
        get { return "Sobrepeso"; }
    }

    public override string Risk
    {
        get { return "Aumentado"; }
    }

    public override bool CheckBMI(double bmi) => bmi >= 25 && bmi <= 29.99;
}
