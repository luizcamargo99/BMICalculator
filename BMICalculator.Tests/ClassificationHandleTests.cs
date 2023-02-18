namespace BMICalculator.Tests
{
    public class ClassificationHandleTests
    {
        [Theory]
        [InlineData(1, "Magreza Grau III", "Sem Risco")]
        [InlineData(13, "Magreza Grau III", "Sem Risco")]
        [InlineData(15.9, "Magreza Grau III", "Sem Risco")]
        [InlineData(16, "Magreza Grau II", "Sem Risco")]
        [InlineData(16.5, "Magreza Grau II", "Sem Risco")]
        [InlineData(16.9, "Magreza Grau II", "Sem Risco")]
        [InlineData(17, "Magreza Grau I", "Sem Risco")]
        [InlineData(17.3, "Magreza Grau I", "Sem Risco")]
        [InlineData(18.47, "Magreza Grau I", "Sem Risco")]
        [InlineData(18.5, "Eutrofia", "Sem Risco")]
        [InlineData(22, "Eutrofia", "Sem Risco")]
        [InlineData(24.9, "Eutrofia", "Sem Risco")]
        [InlineData(25, "Sobrepeso", "Aumentado")]
        [InlineData(27.8, "Sobrepeso", "Aumentado")]
        [InlineData(29.9, "Sobrepeso", "Aumentado")]
        [InlineData(30, "Obesidade Grau I", "Moderado")]
        [InlineData(32.9, "Obesidade Grau I", "Moderado")]
        [InlineData(34.9, "Obesidade Grau I", "Moderado")]
        [InlineData(35, "Obesidade Grau II", "Grave")]
        [InlineData(37.55, "Obesidade Grau II", "Grave")]
        [InlineData(40, "Obesidade Grau II", "Grave")]
        [InlineData(40.1, "Obesidade Grau III", "Muito Grave")]
        [InlineData(41, "Obesidade Grau III", "Muito Grave")]
        [InlineData(45.52, "Obesidade Grau III", "Muito Grave")]
        public void TestGetClassificationByBMISuccess(double bmi, string descriptionExpected, string riskExpected)
        {
            var classification = new ClassificationHandle().GetClassificationByBMI(bmi);
            Assert.Equal(descriptionExpected, classification.Description);
            Assert.Equal(riskExpected, classification.Risk);
        }
    }
}