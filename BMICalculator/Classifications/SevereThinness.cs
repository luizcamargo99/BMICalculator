namespace BMICalculator.Classifications;

public class SevereThinness : Classification
{
    public override string Description
    {
        get { return "Magreza Grau III"; }
    }

    public override string Risk
    {
        get { return "Sem Risco"; }
    }

    public override bool CheckBMI(double bmi) => bmi < 16;
}
