using Assignment2;

namespace Assignment2UnitTests;

public class LoopCoverageTags
{
    private const double Epsilon = 1e-8;
    
    [Test]
    public void Tax_NoIncomeNoChildrenNoParents_NoLoopCoverage()
    {
        //arrange
        double[] incomeList = new double[] { };
        int[] parentList = new int[] { };
        int[] childList = new int[] { };
        const double expected = 0.0d;
        
        //act
        double computedTax = TaxCalculator
            .ComputeTax(incomeList, parentList, childList);
        
        //assert
        Assert.That(computedTax, Is.EqualTo(expected).Within(Epsilon));
    }
    
    [Test]
    public void Tax_40kIncome1Child1Parent_AllLoopsCoverage()
    {
        //arrange
        double[] incomeList = new double[] { 40000 };
        int[] parentList = new int[] { 65 };
        int[] childList = new int[] { 16 };
        const double expected = 0.0d;
        
        //act
        double computedTax = TaxCalculator
            .ComputeTax(incomeList, parentList, childList);
        
        //assert
        Assert.That(computedTax, Is.EqualTo(expected).Within(Epsilon));
    }
}