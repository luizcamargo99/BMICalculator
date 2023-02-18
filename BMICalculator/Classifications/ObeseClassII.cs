namespace BMICalculator.Classifications;

public class ObeseClassII : Classification
{
    public override string Description
    {
        get { return "Obesidade Grau II"; }
    }

    public override string Risk
    {
        get { return "Grave"; }
    }

    public override bool CheckBMI(double bmi) => bmi >= 35 && bmi <= 40;
}
