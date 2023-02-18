namespace BMICalculator.Classifications;

public class MildThinness : Classification
{
    public override string Description
    {
        get { return "Magreza Grau I"; }
    }

    public override string Risk
    {
        get { return "Sem Risco"; }
    }

    public override bool CheckBMI(double bmi) => bmi >= 17 && bmi <= 18.49;
}
