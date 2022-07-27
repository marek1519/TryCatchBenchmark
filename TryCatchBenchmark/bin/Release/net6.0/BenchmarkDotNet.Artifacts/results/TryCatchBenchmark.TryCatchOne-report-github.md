``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-8300H CPU 2.30GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400-preview.22330.6
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  DefaultJob : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT


```
|            Method |     Mean |     Error |    StdDev | Allocated |
|------------------ |---------:|----------:|----------:|----------:|
| DoSomethingSingle | 1.369 μs | 0.0272 μs | 0.0254 μs |         - |
|       DoSomething | 1.063 μs | 0.0095 μs | 0.0079 μs |         - |
