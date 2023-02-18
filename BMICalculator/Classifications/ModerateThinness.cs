namespace BMICalculator.Classifications;

public class ModerateThinness : Classification
{
    public override string Description
    {
        get { return "Magreza Grau II"; }
    }

    public override string Risk
    {
        get { return "Sem Risco"; }
    }

    public override bool CheckBMI(double bmi) => bmi >= 16 && bmi <= 16.99;
}
