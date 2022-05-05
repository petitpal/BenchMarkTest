``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1526 (20H2/October2020Update)
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT DEBUG
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|     Method |    Mean |    Error |   StdDev |
|----------- |--------:|---------:|---------:|
| Countto100 | 1.626 s | 0.0319 s | 0.0298 s |
| CountTo200 | 3.223 s | 0.0625 s | 0.0812 s |
