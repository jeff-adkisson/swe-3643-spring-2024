using MathLibrary;
using Xunit.Abstractions;

namespace MathLibraryTest;

public class BasicFloatingPointOperationsTests(
    ITestOutputHelper testOutputHelper)
{
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