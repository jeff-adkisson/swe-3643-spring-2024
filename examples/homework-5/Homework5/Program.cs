PrintPrimes(100);
//PrintPrimes2(100);
return;

//////////

static bool IsDivisible (int i, int j)
{
    return j % i == 0;
}

static string PrintPrimes(int n)
{
    int curPrime;           // Value currently considered for primeness
    int numPrimes;          // Number of primes found so far.
    bool isPrime;        // Is curPrime prime?
    int[] primes = new int[100]; // The list of prime numbers.
    string str = "";

    // Initialize 2 into the list of primes.
    primes[0] = 2;
    numPrimes = 1;
    curPrime = 2;
    while (numPrimes < n)
    {
        curPrime++;  // next number to consider ...
        isPrime = true;
        for (int i = 0; i <= numPrimes - 1; i++)
        {   // for each previous prime.
            if (IsDivisible(primes[i], curPrime))
            {  // Found a divisor, curPrime is not prime.
                isPrime = false;
                break; // out of loop through primes.
            }
        }
        if (isPrime)
        {   // save it!
            primes[numPrimes] = curPrime;
            numPrimes++;
        }
    }  // End while

    // Print all the primes out.
    for (int i = 0; i <= numPrimes - 1; i++)
    {
        str += " " + primes[i];
    }

    Console.WriteLine(str);

    return str;
}  // end printPrimes

////////
// REFACTORED
////////

static void PrintPrimes2(int primesToGet)
{
    int[] primes = GetPrimes(primesToGet);
    var output = "";
    foreach (var prime in primes)
    {
        output += $" {prime}";
    }
    Console.WriteLine(output);
}

static int[] GetPrimes(int primesToGet)
{
    if (primesToGet < 1)
    {
        throw new ArgumentException("Value must be 1 or greater", nameof(primesToGet));
    }

    //init
    int[] primes = new int[primesToGet];
    int possiblePrime = 2;
    int primesFound = 1;
    primes[primesFound - 1] = possiblePrime;

    while (primesFound < primesToGet)
    {
        possiblePrime++;
        bool isPrime = true;
        for (int i = 0; i < primesFound; i++)
        {
            if (primes[i] > possiblePrime / 2)
                break; //cannot be a divisor

            isPrime = (possiblePrime % primes[i]) != 0;
            if (!isPrime) break;
        }

        if (!isPrime) continue;

        primes[primesFound] = possiblePrime;
        primesFound++;
    }
    return primes;
}