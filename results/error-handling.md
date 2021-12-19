## Error handling

|                Type |          Mean |       Error |      StdDev |
|-------------------- |--------------:|------------:|------------:|
|           Exception | 10,594.225 ns | 195.7650 ns | 316.1240 ns |
|     OutputParameter |      2.385 ns |   0.0899 ns |   0.1732 ns |
|      **ReturnCode** |  **2.283 ns** |   0.0847 ns |   0.1071 ns |
|        ReturnResult |      9.304 ns |   0.2272 ns |   0.4154 ns |

**Summary**

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043<br>
Intel Xeon Gold 6130 CPU 2.10GHz, 1 CPU, 4 logical and 4 physical cores<br>
.NET Core SDK=5.0.300<br>
  [Host]     : .NET Core 5.0.6 (CoreCLR 5.0.621.22011, CoreFX 5.0.621.22011), X64 RyuJIT<br>
  DefaultJob : .NET Core 5.0.6 (CoreCLR 5.0.621.22011, CoreFX 5.0.621.22011), X64 RyuJIT<br>