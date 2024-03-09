using System.Text;

namespace Homework5;

public static class Homework5Refactored
{
    public static void PrintPrimes(int primesToGet)
    {
        var primes = GetPrimesArray(primesToGet);
        var output = new StringBuilder();
        foreach (var prime in primes) output.Append($" {prime}");
        Console.WriteLine(output);
    }

    public static int[] GetPrimesArray(int primesToGet)
    {
        if (primesToGet < 1) throw new ArgumentException("Value must be 1 or greater", nameof(primesToGet));

        //init
        var primes = new int[primesToGet];
        var possiblePrime = 2;
        var primesFound = 1;
        primes[primesFound - 1] = possiblePrime;

        while (primesFound < primesToGet)
        {
            possiblePrime++;
            var isPrime = true;
            var stopWhenMoreThanDouble = possiblePrime / 2;
            for (var i = 0; i < primesFound; i++)
            {
                if (primes[i] > stopWhenMoreThanDouble)
                    break; //cannot be a divisor

                isPrime = possiblePrime % primes[i] != 0;
                if (!isPrime) break;
            }

            if (!isPrime) continue;

            primes[primesFound] = possiblePrime;
            primesFound++;
        }

        return primes;
    }
}