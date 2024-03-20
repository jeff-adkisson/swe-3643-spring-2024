using BenchmarkDotNet.Running;
using Homework5Benchmarks;

#if (DEBUG)
    throw new InvalidOperationException("You cannot run benchmarks in Debug mode. Switch IDE or build to Release");
#endif

Console.WriteLine("Copy results to https://chartbenchmark.net/ to visualize.");

BenchmarkRunner.Run<Benchmark100Primes>();
// BenchmarkRunner.Run<Benchmark1PrimeString>();
// BenchmarkRunner.Run<LargePrimeListBenchmarks>();
