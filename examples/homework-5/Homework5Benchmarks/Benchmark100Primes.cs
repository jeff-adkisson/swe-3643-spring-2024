using BenchmarkDotNet.Attributes;
using Homework5;

namespace Homework5Benchmarks;

[MemoryDiagnoser]
public class Benchmark100Primes
{
    private const int Operations = 100;
    private const int Min = 1;
    private const int Max = 100;
    
    private int[] _primesToGet = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rand = new Random(19700101);
        _primesToGet = new int[Operations];
        for (int i = 0; i < Operations; i++)
        {
            _primesToGet[i] = rand.Next(Min, Max);
        }
    }
    
    [Benchmark]
    public void Homework5Original_GetPrimesString()
    {
        foreach (var primesToGet in _primesToGet)
        {
            var primesString = Homework5Original.GetPrimesAsString(primesToGet);
        }
    }
    
    [Benchmark]
    public void Homework5Original_GetPrimesStringViaStringBuilder()
    {
        foreach (var primesToGet in _primesToGet)
        {
            var primesString = Homework5Original.GetPrimesAsStringViaStringBuilder(primesToGet);
        }
    }
    
    [Benchmark]
    public void Homework5Original_GetPrimesArray()
    {
        foreach (var primesToGet in _primesToGet)
        {
            var primesArray = Homework5Original.GetPrimesArray(primesToGet);
        }
    }
    
    [Benchmark]
    public void Homework5Refactored_GetPrimes()
    {
        foreach (var primesToGet in _primesToGet)
        {
            var primesArray = Homework5Refactored.GetPrimesArray(primesToGet);
        }
    }
    
    [Benchmark]
    public void Homework5RefactoredSingleResponsibility_GetPrimes()
    {
        foreach (var primesToGet in _primesToGet)
        {
            var primesArray = Homework5RefactoredSingleResponsibility.GetPrimesArray(primesToGet);
        }
    }
}