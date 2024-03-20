using BenchmarkDotNet.Attributes;
using Homework5;

namespace Homework5Benchmarks;

[MemoryDiagnoser]
public class Benchmark1PrimeString
{
    [Benchmark]
    public void Homework5Original_GetSinglePrime_String()
    {
        var singlePrimeString = Homework5Original.GetPrimesAsString(1);
    }

    [Benchmark]
    public void Homework5Refactored_GetSinglePrime_String()
    {
        var singlePrimeString = Homework5Refactored.GetPrimesAsString(1);
    }
}