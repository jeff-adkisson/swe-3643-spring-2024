using System.Text;

namespace Homework5;

public static class Homework5RefactoredSingleResponsibility
{
    public static void PrintPrimes(int primesToGet)
    {
        var primes = GetPrimesArray(primesToGet);
        var output = new StringBuilder();
        foreach (var prime in primes) output.Append($" {prime}");
        Console.WriteLine(output);
    }
    
    private static int GetNextPrime(int[] priorPrimes, int mostRecentPrime)
    {
        while (true)
        {
            mostRecentPrime += 2;
            var isPrime = true;
            var stopWhenMoreThan = Math.Sqrt(mostRecentPrime);
            for (var index = 0; index < priorPrimes.Length; index++)
            {
                var priorPrime = priorPrimes[index];
                if (priorPrime > stopWhenMoreThan)
                    break; //cannot be a divisor

                isPrime = mostRecentPrime % priorPrime != 0;
                if (!isPrime) break;
            }

            if (isPrime) return mostRecentPrime;
        }
    }

    public static int[] GetPrimesArray(int primesToGet)
    {
        if (primesToGet < 1) 
            throw new ArgumentException("Value must be 1 or greater", nameof(primesToGet));
        
        int[] primes = new int[primesToGet];
        int mostRecentPrime = 1;
        primes[0] = 2;
        
        for (int i = 1; i < primesToGet; i++)
        {
            mostRecentPrime = GetNextPrime(primes, mostRecentPrime);
            primes[i] = mostRecentPrime;
        }

        return primes;
    }
}