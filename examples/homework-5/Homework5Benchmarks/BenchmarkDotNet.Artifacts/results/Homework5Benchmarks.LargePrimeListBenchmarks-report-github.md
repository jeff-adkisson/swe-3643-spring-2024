```

BenchmarkDotNet v0.13.12, macOS Sonoma 14.2.1 (23C71) [Darwin 23.2.0]
Apple M2 Max, 1 CPU, 12 logical and 12 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.0 (8.0.23.53103), Arm64 RyuJIT AdvSIMD


```
| Method                                                    | Mean    | Error    | StdDev   | Allocated |
|---------------------------------------------------------- |--------:|---------:|---------:|----------:|
| Homework5Original_GetLargePrimeList                       | 3.812 s | 0.0107 s | 0.0095 s | 391.37 KB |
| Homework5Refactored_GetLargePrimeList                     | 2.396 s | 0.0038 s | 0.0034 s | 391.37 KB |
| Homework5RefactoredSingleResponsibility_GetLargePrimeList | 2.398 s | 0.0086 s | 0.0076 s | 391.37 KB |
