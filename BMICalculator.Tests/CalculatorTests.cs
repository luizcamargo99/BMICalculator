namespace BMICalculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(90.2, 1.75, 29.45)]
        [InlineData(75, 1.95, 19.72)]
        public void TestCalculateSuccess(float weight, float height, float resultExpected)
        {
            var result = new Calculator().Calculate(weight, height);
            Assert.Equal(resultExpected, result);
        }
    }
}