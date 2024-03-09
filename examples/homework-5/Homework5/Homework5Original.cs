using System.Text;

namespace Homework5;

public static class Homework5Original
{
    private static bool IsDivisible(int i, int j)
    {
        return j % i == 0;
    }
    
    public static string GetPrimesOriginal(int n)
    {
        int curPrime; // Value currently considered for primeness
        int numPrimes; // Number of primes found so far.
        bool isPrime; // Is curPrime prime?
        var primes = new int[100]; // The list of prime numbers.
        var str = "";

        // Initialize 2 into the list of primes.
        primes[0] = 2;
        numPrimes = 1;
        curPrime = 2;
        while (numPrimes < n)
        {
            curPrime++; // next number to consider ...
            isPrime = true;
            for (var i = 0; i <= numPrimes - 1; i++)
                // for each previous prime.
                if (IsDivisible(primes[i], curPrime))
                {
                    // Found a divisor, curPrime is not prime.
                    isPrime = false;
                    break; // out of loop through primes.
                }

            if (isPrime)
            {
                // save it!
                primes[numPrimes] = curPrime;
                numPrimes++;
            }
        } // End while

        // Print all the primes out.
        for (var i = 0; i <= numPrimes - 1; i++) str += " " + primes[i];
        
        Console.WriteLine(str);

        return str;
    } // end printPrimes

    public static string PrintPrimes(int n)
    {
        string primes = GetPrimesAsString(n);
        Console.WriteLine(primes);
        return primes;
    }

    public static string GetPrimesAsString(int n)
    {
        int curPrime; // Value currently considered for primeness
        int numPrimes; // Number of primes found so far.
        bool isPrime; // Is curPrime prime?
        var primes = new int[100]; // The list of prime numbers.
        var str = "";

        // Initialize 2 into the list of primes.
        primes[0] = 2;
        numPrimes = 1;
        curPrime = 2;
        while (numPrimes < n)
        {
            curPrime++; // next number to consider ...
            isPrime = true;
            for (var i = 0; i <= numPrimes - 1; i++)
                // for each previous prime.
                if (IsDivisible(primes[i], curPrime))
                {
                    // Found a divisor, curPrime is not prime.
                    isPrime = false;
                    break; // out of loop through primes.
                }

            if (isPrime)
            {
                // save it!
                primes[numPrimes] = curPrime;
                numPrimes++;
            }
        } // End while

        // Print all the primes out.
        for (var i = 0; i <= numPrimes - 1; i++) str += " " + primes[i];

        return str;
    } // end printPrimes
    
    public static string GetPrimesAsStringViaStringBuilder(int n)
    {
        int curPrime; // Value currently considered for primeness
        int numPrimes; // Number of primes found so far.
        bool isPrime; // Is curPrime prime?
        var primes = new int[100]; // The list of prime numbers.
        var str = "";

        // Initialize 2 into the list of primes.
        primes[0] = 2;
        numPrimes = 1;
        curPrime = 2;
        while (numPrimes < n)
        {
            curPrime++; // next number to consider ...
            isPrime = true;
            for (var i = 0; i <= numPrimes - 1; i++)
                // for each previous prime.
                if (IsDivisible(primes[i], curPrime))
                {
                    // Found a divisor, curPrime is not prime.
                    isPrime = false;
                    break; // out of loop through primes.
                }

            if (isPrime)
            {
                // save it!
                primes[numPrimes] = curPrime;
                numPrimes++;
            }
        } // End while

        // Print all the primes out.
        var sb = new StringBuilder();
        for (var i = 0; i <= numPrimes - 1; i++) sb.Append(" " + primes[i]);

        return str;
    } // end printPrimes
    
    public static int[] GetPrimesArray(int n)
    {
        int curPrime; // Value currently considered for primeness
        int numPrimes; // Number of primes found so far.
        bool isPrime; // Is curPrime prime?
        var primes = new int[100]; // The list of prime numbers.

        // Initialize 2 into the list of primes.
        primes[0] = 2;
        numPrimes = 1;
        curPrime = 2;
        while (numPrimes < n)
        {
            curPrime++; // next number to consider ...
            isPrime = true;
            for (var i = 0; i <= numPrimes - 1; i++)
                // for each previous prime.
                if (IsDivisible(primes[i], curPrime))
                {
                    // Found a divisor, curPrime is not prime.
                    isPrime = false;
                    break; // out of loop through primes.
                }

            if (isPrime)
            {
                // save it!
                primes[numPrimes] = curPrime;
                numPrimes++;
            }
        } // End while

        return primes;
    } // end printPrimes
    
    public static int[] GetPrimesArrayDynamicSize(int n)
    {
        int curPrime; // Value currently considered for primeness
        int numPrimes; // Number of primes found so far.
        bool isPrime; // Is curPrime prime?
        var primes = new int[n]; // The list of prime numbers.

        // Initialize 2 into the list of primes.
        primes[0] = 2;
        numPrimes = 1;
        curPrime = 2;
        while (numPrimes < n)
        {
            curPrime++; // next number to consider ...
            isPrime = true;
            for (var i = 0; i <= numPrimes - 1; i++)
                // for each previous prime.
                if (IsDivisible(primes[i], curPrime))
                {
                    // Found a divisor, curPrime is not prime.
                    isPrime = false;
                    break; // out of loop through primes.
                }

            if (isPrime)
            {
                // save it!
                primes[numPrimes] = curPrime;
                numPrimes++;
            }
        } // End while

        return primes;
    } // end printPrimes
}