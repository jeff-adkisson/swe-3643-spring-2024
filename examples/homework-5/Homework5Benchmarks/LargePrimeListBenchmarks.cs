using BenchmarkDotNet.Attributes;
using Homework5;

namespace Homework5Benchmarks;

[MemoryDiagnoser]
public class LargePrimeListBenchmarks
{
    private const int PrimesToGet = 100000;
    
    [Benchmark]
    public void Homework5Original_GetLargePrimeList()
    {
        var primesArray = Homework5Original.GetPrimesArrayDynamicSize(PrimesToGet);
    }

    [Benchmark]
    public void Homework5Refactored_GetLargePrimeList()
    {
        var primesArray = Homework5Refactored.GetPrimesArray(PrimesToGet);
    }
    
    [Benchmark]
    public void Homework5RefactoredSingleResponsibility_GetLargePrimeList()
    {
        var primesArray = Homework5RefactoredSingleResponsibility.GetPrimesArray(PrimesToGet);
    }
}
