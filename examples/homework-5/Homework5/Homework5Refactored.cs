using System.Text;

namespace Homework5;

public static class Homework5Refactored
{
    public static void PrintPrimes(int primesToGet)
    {
        Console.WriteLine(GetPrimesAsString(primesToGet));
    }
    
    public static string GetPrimesAsString(int primesToGet)
    {
        var primes = GetPrimesArray(primesToGet);
        string output = "";
        for (int i = 0; i < primes.Length; i++)
        {
            output += primes[i] + " ";
        }
        return output;
    }

    public static int[] GetPrimesArray(int primesToGet)
    {
        if (primesToGet < 1) throw new ArgumentException("Value must be 1 or greater", nameof(primesToGet));

        //init
        var primes = new int[primesToGet];
        var possiblePrime = 1;
        var primesFound = 1;
        primes[primesFound - 1] = 2;

        while (primesFound < primesToGet)
        {
            possiblePrime += 2;
            var isPrime = true;
            var stopWhenMoreThan = Math.Sqrt(possiblePrime);
            for (var i = 0; i < primesFound; i++)
            {
                if (primes[i] > stopWhenMoreThan)
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