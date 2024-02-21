namespace Homework1TwoDigitAddExhaustive;

[TestFixture]
public class TwoDigitIntegerPositiveNegativeSumExhaustiveTests
{
    private const bool ShowConsoleOutput = true;
    private const int DelayMs = 0;

    [Test, TestCaseSource(typeof(TwoDigitIntegerCombinationGenerator))]
    public async Task Add_TwoDigitIntegerCombination_ReturnsCorrectSum(
        TwoDigitIntegerCombination testCriteria
    )
    {
#pragma warning disable CS0162 // Unreachable code detected

        // Arrange
        var left = testCriteria.Left;
        var right = testCriteria.Right;
        var expected = testCriteria.Expected;
        
        if (ShowConsoleOutput) {
            Console.WriteLine(
                $"left: {left}, right: {right}, expected: {expected}");
        }       
        
        // Act
        var actual = left + right;
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        
        //homework said test takes 1000ms - here's how
        //to give that a try
        if (DelayMs > 0)
        {
            await Task.Delay(DelayMs);
        }
        else
        {
            await Task.CompletedTask;
        }
        
#pragma warning restore CS0162 // Unreachable code detected
    }
}