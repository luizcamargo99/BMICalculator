namespace BMICalculator.Classifications;

public abstract class Classification
{
    public abstract string Description { get; }
    public abstract string Risk { get; }
    public abstract bool CheckBMI(double bmi);
}
