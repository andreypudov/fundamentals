## Collections

|                         Type |    Method |  type |             Mean |           Error |          StdDev |
|----------------------------- |---------- |------ |-----------------:|----------------:|----------------:|
| **ImmutableArrayCollection** | FindFirst | Small |      12,523.6 ns |       217.37 ns |       213.49 ns |
|      ImmutableListCollection | FindFirst | Small |      83,135.6 ns |     1,053.12 ns |       985.09 ns |
|         LinkedListCollection | FindFirst | Small |      45,599.6 ns |       774.04 ns |       646.35 ns |
|               ListCollection | FindFirst | Small |      13,189.1 ns |       245.72 ns |       229.85 ns |
|           ReadOnlyCollection | FindFirst | Small |      14,393.4 ns |       228.33 ns |       271.81 ns |
|||||||
| **ImmutableArrayCollection** |  FindLast | Small |     720,591.4 ns |    14,307.67 ns |    13,383.40 ns |
|      ImmutableListCollection |  FindLast | Small |   8,198,595.4 ns |   146,227.39 ns |   129,626.77 ns |
|         LinkedListCollection |  FindLast | Small |   2,775,011.7 ns |    49,695.28 ns |    46,485.00 ns |
|               ListCollection |  FindLast | Small |     727,183.6 ns |    14,296.22 ns |    13,372.69 ns |
|           ReadOnlyCollection |  FindLast | Small |   1,487,886.7 ns |    29,238.04 ns |    34,805.81 ns |
|||||||
| **ImmutableArrayCollection** |    Filter | Small |       2,351.7 ns |        37.87 ns |        33.57 ns |
|      ImmutableListCollection |    Filter | Small |      75,221.6 ns |     1,233.55 ns |     1,468.46 ns |
|         LinkedListCollection |    Filter | Small |      54,610.1 ns |     1,073.87 ns |     1,505.42 ns |
|               ListCollection |    Filter | Small |       2,448.3 ns |        49.03 ns |        63.76 ns |
|           ReadOnlyCollection |    Filter | Small |         306.4 ns |         5.89 ns |         7.45 ns |
|||||||
|     ImmutableArrayCollection | FindFirst | Large |     252,812.0 ns |     4,711.23 ns |     4,406.89 ns |
|      ImmutableListCollection | FindFirst | Large |   1,388,034.1 ns |    27,351.53 ns |    31,498.06 ns |
|         LinkedListCollection | FindFirst | Large |   1,109,264.1 ns |    21,481.75 ns |    22,060.18 ns |
|               ListCollection | FindFirst | Large |     260,819.3 ns |     5,156.08 ns |     5,730.97 ns |
|       **ReadOnlyCollection** | FindFirst | Large |      16,801.2 ns |       309.93 ns |       402.99 ns |
|||||||
|     ImmutableArrayCollection |  FindLast | Large |  33,874,376.2 ns |   613,335.66 ns |   573,714.56 ns |
|      ImmutableListCollection |  FindLast | Large | 283,879,305.0 ns | 5,481,752.45 ns | 6,312,794.28 ns |
|         LinkedListCollection |  FindLast | Large |  98,087,332.7 ns | 1,958,853.28 ns | 2,809,328.84 ns |
|           **ListCollection** |  FindLast | Large |  33,360,925.0 ns |   651,335.79 ns |   954,719.55 ns |
|           ReadOnlyCollection |  FindLast | Large |  56,678,133.9 ns | 1,117,417.17 ns | 1,286,819.27 ns |
|||||||
|     ImmutableArrayCollection |    Filter | Large |     464,333.5 ns |     4,158.76 ns |     3,246.89 ns |
|      ImmutableListCollection |    Filter | Large |   2,426,227.2 ns |    46,369.76 ns |    45,541.30 ns |
|         LinkedListCollection |    Filter | Large |   2,156,584.5 ns |    40,422.55 ns |    37,811.28 ns |
|               ListCollection |    Filter | Large |     464,362.0 ns |     5,981.92 ns |     5,595.49 ns |
|       **ReadOnlyCollection** |    Filter | Large |         295.9 ns |         5.87 ns |         9.14 ns |

**Summary**

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1415 (21H2)
Intel Xeon Gold 6130 CPU 2.10GHz, 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT