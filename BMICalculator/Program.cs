using BMICalculator;

Console.Clear();

try
{
    Console.WriteLine("Informe sua altura:");
    float.TryParse(Console.ReadLine(), out float height);

    Console.WriteLine("Informe seu peso:");
    float.TryParse(Console.ReadLine(), out float weight);

    ValidateFields(height, weight);

    var bmi = new Calculator().Calculate(weight, height);
    var classification = new ClassificationHandle().GetClassificationByBMI(bmi);

    Console.WriteLine($"Seu IMC é {bmi}");
    Console.WriteLine(classification.Description);
    Console.WriteLine($"Risco: {classification.Risk}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void ValidateFields(float height, float weight)
{
    if (height == 0 || weight == 0)
        throw new Exception("Insira valores válidos...");
}


