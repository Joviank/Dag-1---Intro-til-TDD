namespace Calculator.Tests;

public class CalculatorTester
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange: Set up data
        var calculator = new Calculator();

        // Act: Run the test
        var result = calculator.Add(2, 2);

        // Assert: Check if the result is correct
        Assert.Equal(4, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnCorrectSum()
    {
        // Arrange: We make a calculator
        var calculator = new Calculator();

        // Act: We subtract two numbers
        var result = calculator.Subtract(10, 5);

        // Assert: The result should be 5
        Assert.Equal(5, result);
    }
}
