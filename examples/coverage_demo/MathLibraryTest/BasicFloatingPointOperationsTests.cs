using Xunit.Abstractions;

namespace MathLibraryTest;

public class BasicFloatingPointOperationsTests(
    ITestOutputHelper testOutputHelper)
{
    public ITestOutputHelper TestOutputHelper { get; } = testOutputHelper;
    //aaa test pattern - arrange, act, assert
    //https://medium.com/@pjbgf/title-testing-code-ocd-and-the-aaa-pattern-df453975ab80

    private const int Precision = 4;
    private readonly MathLibrary.BasicFloatingPointOperations _sut = new(Precision); // SUT = System Under Test

    [Fact]
    public void Addition_Should_AddTwoFloatingPointNumbers()
    {
        // Arrange
        var a = 1.5;
        var b = 2.75;
        var expected = 4.25;
        
        // Act
        var result = _sut.Add(a, b);
        
        // Assert
        Assert.Equal(expected, result, Precision);
    }
    
    [Fact]
    public void Equals_Should_MatchTwoFloatingPointNumbers()
    {
        // Arrange
        var a = 1.5002;
        var b = 1.5001;
        
        // Act
        var result = _sut.Equals(a, b);
        
        // Assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(1.50020001, 1.5001, false)]
    [InlineData(1.5002, 1.5001, true)]
    [InlineData(1.5001, 1.5001, true)]
    [InlineData(-1.5001, -1.5001, true)]
    public void Equals_Should_MatchTwoFloatingPointNumbers_Theory(double a, double b, bool isEqual )
    {
        // Arrange
        
        // Act
        var result = _sut.Equals(a, b);
        TestOutputHelper.WriteLine($"{a} == {b} is {result}");
        
        // Assert
        Assert.True(result == isEqual);
    }
    
    [Fact]
    public void EqualityLabel_Should_ReturnEqual()
    {
        // Arrange
        var a = 1.5;
        var b = 1.5;
        
        // Act
        var result = _sut.GetEqualityLabel(a, b);
        testOutputHelper.WriteLine(result);
        
        // Assert
        Assert.Contains("equals", result);
    }
}