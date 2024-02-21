using System.Collections;

namespace Homework1TwoDigitAddExhaustive;

public class TwoDigitIntegerCombinationGenerator 
    : IEnumerable<TwoDigitIntegerCombination>
{
    private static readonly TwoDigitIntegerCombination[] AllCombinations 
        = GetAllCombinations();

    private static TwoDigitIntegerCombination[] GetAllCombinations()
    {
        var allTwoDigitIntegers = new List<int>();
        for (var i = -99; i < -9; i++) allTwoDigitIntegers.Add(i);
        for (var i = 10; i < 100; i++) allTwoDigitIntegers.Add(i);

        var totalCombinations = allTwoDigitIntegers.Count * allTwoDigitIntegers.Count;
        var twoDigitIntegerCombos = new TwoDigitIntegerCombination[totalCombinations];

        var index = 0;
        foreach (var leftInt in allTwoDigitIntegers)
        {
            foreach (var rightInt in allTwoDigitIntegers)
            {
                twoDigitIntegerCombos[index] = new TwoDigitIntegerCombination(
                    leftInt, rightInt, leftInt + rightInt
                );
                index++;
            }
        }

        Console.WriteLine($"Two Digit Integer Count: {allTwoDigitIntegers.Count}");
        Console.WriteLine($"Total Combinations: {totalCombinations}");
        return twoDigitIntegerCombos;
    }

    public IEnumerator<TwoDigitIntegerCombination> GetEnumerator()
    {
        return AllCombinations
            .Cast<TwoDigitIntegerCombination>()
            .GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}