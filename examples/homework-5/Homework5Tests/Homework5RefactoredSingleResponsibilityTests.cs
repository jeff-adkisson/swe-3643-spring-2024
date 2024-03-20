using Homework5;

namespace Homework5Tests;

[TestFixture]
public class Homework5RefactoredSingleResponsibilityTests
{
    private const int PrimesToGet = 10000;
    private const int Repeat = 1; //for performance profiling

    
    [Test]
    public void Homework5RefactoredSingleResponsibility_RandomCountsToRetrieve_AllVersionsReturnSamePrimes()
    {
        int[] primesArray = null!;
        for (int i = 0; i < Repeat; i++)
        {
            primesArray = Homework5RefactoredSingleResponsibility.GetPrimesArray(PrimesToGet);
        }
        Assert.That(primesArray, Has.Length.EqualTo(PrimesToGet));
        Assert.That(primesArray, Is.All.Matches<int>(IsPrime));

    }
    
    //https://stackoverflow.com/a/37349945
    private static bool IsPrime(int number) {
        if (number <= 1)
            return false;
        if (number % 2 == 0)
            return number == 2;

        var n = (long) (Math.Sqrt(number) + 0.5);

        for (var i = 3; i <= n; i += 2)
            if (number % i == 0)
                return false; 

        return true;
    }
}