```

BenchmarkDotNet v0.14.0, macOS Sonoma 14.6.1 (23G93) [Darwin 23.6.0]
Apple M1 Pro, 1 CPU, 8 logical and 8 physical cores
.NET SDK 7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), Arm64 RyuJIT AdvSIMD


```
| Method                        | conteo | Mean        | Error    | StdDev   | Ratio | Gen0   | Allocated | Alloc Ratio |
|------------------------------ |------- |------------:|---------:|---------:|------:|-------:|----------:|------------:|
| **ToListPuntoLongitudMayorACero** | **10**     |    **46.01 ns** | **0.145 ns** | **0.136 ns** |  **1.00** | **0.0191** |     **120 B** |        **1.00** |
| WhereCountMayorACero          | 10     |    34.64 ns | 0.046 ns | 0.043 ns |  0.75 | 0.0076 |      48 B |        0.40 |
| LinqWhereCountMayorACero      | 10     |    28.90 ns | 0.023 ns | 0.019 ns |  0.63 | 0.0076 |      48 B |        0.40 |
| LinqAny                       | 10     |    37.10 ns | 0.099 ns | 0.092 ns |  0.81 | 0.0051 |      32 B |        0.27 |
|                               |        |             |          |          |       |        |           |             |
| **ToListPuntoLongitudMayorACero** | **1000**   | **1,589.02 ns** | **1.384 ns** | **1.227 ns** |  **1.00** | **0.0191** |     **120 B** |        **1.00** |
| WhereCountMayorACero          | 1000   | 1,579.81 ns | 0.884 ns | 0.738 ns |  0.99 | 0.0076 |      48 B |        0.40 |
| LinqWhereCountMayorACero      | 1000   |    28.80 ns | 0.061 ns | 0.054 ns |  0.02 | 0.0076 |      48 B |        0.40 |
| LinqAny                       | 1000   |    37.97 ns | 0.072 ns | 0.064 ns |  0.02 | 0.0051 |      32 B |        0.27 |
