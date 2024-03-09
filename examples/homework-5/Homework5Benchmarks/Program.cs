using BenchmarkDotNet.Running;
using Homework5Benchmarks;

#if (DEBUG)
    throw new InvalidOperationException("You cannot run benchmarks in Debug mode. Switch IDE or build to Release");
#endif

BenchmarkRunner.Run<AllBenchmarks>();

Console.WriteLine("Copy results to https://chartbenchmark.net/ to visualize.");

// BenchmarkRunner.Run<LargePrimeListBenchmarks>();
//
// Console.WriteLine("Copy results to https://chartbenchmark.net/ to visualize.");