namespace BMICalculator.Classifications;

public class ObeseClassIII : Classification
{
    public override string Description
    {
        get { return "Obesidade Grau III"; }
    }

    public override string Risk
    {
        get { return "Muito Grave"; }
    }

    public override bool CheckBMI(double bmi) => bmi > 40;
}
