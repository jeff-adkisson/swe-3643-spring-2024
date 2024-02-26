namespace Assignment2;

public static class TaxCalculator
{
    /// <summary>
    /// Computes the tax amount based on the provided income, parent, and child information.
    /// </summary>
    /// <param name="incomeList">An array of incomes.</param>
    /// <param name="parentList">An array of ages of the parents.</param>
    /// <param name="childList">An array of ages of the children.</param>
    /// <returns>The calculated tax amount.</returns>
    public static double ComputeTax(
        double[] incomeList,
        int[] parentList,
        int[] childList)
    {
        double taxAmount = 0.0;
        double incomeAmount = 0.0;
    
        // calculate the income amount
        for (int i = 0; i < incomeList.Length; i++)
        {
            incomeAmount = incomeAmount + incomeList[i];
        }

        // calculate the basic tax
        if (incomeAmount <= 40000)
        {
            taxAmount = incomeAmount * 0.02d;
        }
        else if (incomeAmount > 40000 && incomeAmount <= 80000)
        {
            taxAmount = 800 + (incomeAmount * 0.07d);
        }
        else if (incomeAmount > 80000 && incomeAmount <= 120000)
        {
            taxAmount = 800 + 2800 + (incomeAmount * 0.12d);
        }
        else if (incomeAmount > 120000)
        {
            taxAmount = 800 + 2800 + 4800 + (incomeAmount * 0.17d);
        }

        // calculate the tax exemption from having children
        int taxExemption = 0;
        int numOfChild = childList.Length;
        while (numOfChild > 0)
        {
            if (childList[numOfChild - 1] < 18)
            {
                taxAmount = taxAmount - 4000;
                taxExemption = taxExemption + 4000;
            }

            numOfChild--;
        }

        // calculate the tax exemption from having parents
        for (int j = 0; j < parentList.Length; j++)
        {
            if (parentList[j] > 60)
            {
                taxAmount = taxAmount - 2000;
                taxExemption = taxExemption + 2000;
            }

        }

        // the maximum tax exemption is 8000 each person
        if (taxExemption <= 8000)
        {
            if (taxAmount >= 0)
            {
                return taxAmount;
            }
            else
            { // i.e., taxAmount <0
                return 0;
            }
        }
        else
        { // i.e., taxExemption > 8000
            taxAmount = taxAmount + (taxExemption - 8000);
            return taxAmount;
        }
    }
}