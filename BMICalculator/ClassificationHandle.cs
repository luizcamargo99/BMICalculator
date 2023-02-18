using BMICalculator.Classifications;

namespace BMICalculator;

public class ClassificationHandle
{
    private readonly IList<Classification> _classifications = new List<Classification>()
    {
        new SevereThinness(),
        new ModerateThinness(),
        new MildThinness(),
        new Normal(),
        new Overweight(),
        new ObeseClassI(),
        new ObeseClassII(),
        new ObeseClassIII(),
    };

    public Classification GetClassificationByBMI(double bmi) => _classifications.FirstOrDefault(x => x.CheckBMI(bmi))!;
}
