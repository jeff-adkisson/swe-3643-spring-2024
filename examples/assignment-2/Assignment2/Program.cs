//EXAMPLE CALL - DOES *NOT* EXECUTE ALL PATHS!

using Assignment2;

double[] incomeList = new double[] { 111000d, 2000d, 15341.34d };
int[] parentList = new int[] { 27, 40 };
int[] childList = new int[] { 13, 18 };

double computedTax = TaxCalculator.ComputeTax(incomeList, parentList, childList);
Console.WriteLine(computedTax);

//END OF EXAMPLE CALL

// incomeList[]: the array recording the individual income items
// parentList[]: the array recording the ages of parents supported by this person
// childList[]: the array recording the ages of children supported by this person

