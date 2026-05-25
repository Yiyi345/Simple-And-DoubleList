```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 7 7435HS 3.10GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.300
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3


```
| Method   | Mean          | Error       | StdDev      | Allocated |
|--------- |--------------:|------------:|------------:|----------:|
| Add      | 58,311.922 μs | 907.7906 μs | 804.7327 μs |  400000 B |
| Contains |      9.933 μs |   0.1311 μs |   0.1226 μs |         - |
| Remove   | 58,568.344 μs | 339.7354 μs | 301.1666 μs |  400000 B |
