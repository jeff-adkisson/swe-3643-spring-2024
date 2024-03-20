using Homework5;

namespace Homework5Tests;

[TestFixture]
public class ComparisonTests
{
    private const int PrimesToGet = 10000;
    private const int Repeat = 1; //for performance profiling
    
    [Test]
    public void Homework5Original_RandomCountsToRetrieve_AllVersionsReturnSamePrimes()
    {
        int[] originalPrimesArray = null!;
        int[] refactoredPrimesArray = null!;
        int[] refactoredSingleResponsibilityPrimesArray = null!;
        for (int i = 0; i < Repeat; i++)
        {
            originalPrimesArray = Homework5Original.GetPrimesArrayDynamicSize(PrimesToGet);
            originalPrimesArray = originalPrimesArray.Where(x => x != 0).ToArray();
            refactoredPrimesArray = Homework5Refactored.GetPrimesArray(PrimesToGet);
            refactoredSingleResponsibilityPrimesArray = Homework5RefactoredSingleResponsibility.GetPrimesArray(PrimesToGet);
        }

        Assert.Multiple(() =>
        {
            Assert.That(refactoredPrimesArray, Is.EqualTo(originalPrimesArray));
            Assert.That(refactoredSingleResponsibilityPrimesArray, Is.EqualTo(originalPrimesArray));
        });
    }
}