using Assignment2;

namespace Assignment2UnitTests;

public class StatementCoverageTests
{
    private const double Epsilon = 1e-8;
    
    [Test]
    public void Tax_40kIncomeChild16Parent65_0Tax()
    {
        //arrange
        double[] incomeList = new double[] { 40000d };
        int[] parentList = new int[] { 65 };
        int[] childList = new int[] { 16 };
        const double expected = 0.0d;
        
        //act
        double computedTax = TaxCalculator
            .ComputeTax(incomeList, parentList, childList);
        
        //assert
        Assert.That(computedTax, Is.EqualTo(expected).Within(Epsilon));
    }
    
    [Test]
    public void Tax_80kIncome_Child16Parent65_400Tax()
    {
        //arrange
        double[] incomeList = new double[] { 80000 };
        int[] parentList = new int[] { 65 };
        int[] childList = new int[] { 16 };
        const double expected = 400.0d;
        
        //act
        double computedTax = TaxCalculator
            .ComputeTax(incomeList, parentList, childList);
        
        //assert
        Assert.That(computedTax, Is.EqualTo(expected).Within(Epsilon));
    }
    
    [Test]
    public void Tax_120kIncomeChildren16and16Parents64and65_10kTax()
    {
        //arrange
        double[] incomeList = new double[] { 120000 };
        int[] parentList = new int[] { 64,65 };
        int[] childList = new int[] { 16,16 };
        const double expected = 10000.0d;
        
        //act
        double computedTax = TaxCalculator
            .ComputeTax(incomeList, parentList, childList);
        
        //assert
        Assert.That(computedTax, Is.EqualTo(expected).Within(Epsilon));
    }
    
    [Test]
    public void Tax_130kIncomeNoChildrenNoParents_30500Tax()
    {
        //arrange
        double[] incomeList = new double[] { 130000 };
        int[] parentList = new int[] { };
        int[] childList = new int[] {  };
        const double expected = 30500.0d;
        
        //act
        double computedTax = TaxCalculator
            .ComputeTax(incomeList, parentList, childList);
        
        //assert
        Assert.That(computedTax, Is.EqualTo(expected).Within(Epsilon));
    }
}