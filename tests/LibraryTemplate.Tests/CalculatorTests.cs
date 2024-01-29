using FluentAssertions;

namespace LibraryTemplate.Tests;

public class CalculatorTests
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2, 3)]
    [InlineData(2, -5, -3)]
    public void Test1(int a, int b, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(a, b);
        result.Should().Be(expected);
    }
}