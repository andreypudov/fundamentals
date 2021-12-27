## Collections

|                         Type |    Method |  type |          Mean |        Error |       StdDev |
|----------------------------- |---------- |------ |--------------:|-------------:|-------------:|
| **ImmutableArrayCollection** | FindFirst | Small |      12.41 us |     0.214 us |     0.200 us |
|      ImmutableListCollection | FindFirst | Small |      85.68 us |     1.458 us |     1.293 us |
|         LinkedListCollection | FindFirst | Small |      44.04 us |     0.881 us |     1.048 us |
|               ListCollection | FindFirst | Small |      19.23 us |     0.375 us |     0.351 us |
|           ReadOnlyCollection | FindFirst | Small |      14.75 us |     0.240 us |     0.224 us |
|||||||
| **ImmutableArrayCollection** |  FindLast | Small |     734.61 us |    14.652 us |    12.989 us |
|      ImmutableListCollection |  FindLast | Small |   8,846.68 us |   172.720 us |   198.905 us |
|         LinkedListCollection |  FindLast | Small |   2,659.40 us |    52.977 us |    52.030 us |
|               ListCollection |  FindLast | Small |   2,328.01 us |    44.736 us |    43.936 us |
|           ReadOnlyCollection |  FindLast | Small |   1,426.39 us |    27.950 us |    37.312 us |
|||||||
|     ImmutableArrayCollection | FindFirst | Large |     242.93 us |     4.351 us |     4.070 us |
|      ImmutableListCollection | FindFirst | Large |   1,311.92 us |    25.715 us |    27.515 us |
|         LinkedListCollection | FindFirst | Large |   1,123.92 us |    21.733 us |    19.266 us |
|               ListCollection | FindFirst | Large |     273.34 us |     3.804 us |     3.372 us |
|       **ReadOnlyCollection** | FindFirst | Large |      15.00 us |     0.295 us |     0.351 us |
|||||||
| **ImmutableArrayCollection** |  FindLast | Large |  33,315.33 us |   563.980 us |   527.547 us |
|      ImmutableListCollection |  FindLast | Large | 309,230.75 us | 5,932.243 us | 7,285.328 us |
|         LinkedListCollection |  FindLast | Large |  92,790.61 us | 1,733.559 us | 1,621.572 us |
|               ListCollection |  FindLast | Large |  84,639.98 us | 1,672.494 us | 2,398.641 us |
|           ReadOnlyCollection |  FindLast | Large |  53,965.93 us | 1,030.394 us | 1,011.985 us |

**Summary**

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1415 (21H2)
Intel Xeon Gold 6130 CPU 2.10GHz, 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT