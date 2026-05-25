```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8457/25H2/2025Update/HudsonValley2)
AMD Ryzen 7 7435HS 3.10GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.300
  [Host]     : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3


```
| Method   | Mean          | Error       | StdDev      | Allocated |
|--------- |--------------:|------------:|------------:|----------:|
| Add      | 56,506.972 μs | 794.8777 μs | 704.6383 μs |  320000 B |
| Contains |      9.501 μs |   0.0138 μs |   0.0129 μs |         - |
| Remove   | 55,860.606 μs |  71.2201 μs |  63.1348 μs |  320000 B |
