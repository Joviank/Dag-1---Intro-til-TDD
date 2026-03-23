namespace Calculator.Tests;

public class CalculatorTester
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange: Sett opp testdata
        var calculator = new Calculator();

        // Act: Utfør handlingen vi tester
        var result = calculator.Add(2, 2);

        // Assert: Sjekk at resultatet er riktig
        Assert.Equal(4, result);
    }
}
