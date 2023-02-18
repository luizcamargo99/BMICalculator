namespace BMICalculator.Classifications;

public class ObeseClassI : Classification
{
    public override string Description
    {
        get { return "Obesidade Grau I"; }
    }

    public override string Risk
    {
        get { return "Moderado"; }
    }

    public override bool CheckBMI(double bmi) => bmi >= 30 && bmi <= 34.99;
}
