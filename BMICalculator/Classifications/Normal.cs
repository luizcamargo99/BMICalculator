namespace BMICalculator.Classifications;

public class Normal : Classification
{
    public override string Description
    {
        get { return "Eutrofia"; }
    }

    public override string Risk
    {
        get { return "Sem Risco"; }
    }

    public override bool CheckBMI(double bmi) => bmi >= 18.50 && bmi <= 24.99;
}
