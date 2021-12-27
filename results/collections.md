## Collections

|                         Type |    Method |  type |           Mean |         Error |        StdDev |         Median |
|----------------------------- |---------- |------ |---------------:|--------------:|--------------:|---------------:|
|     ImmutableArrayCollection | FindFirst | Small |       9.800 us |     0.1924 us |     0.2938 us |       9.816 us |
|      ImmutableListCollection | FindFirst | Small |      54.345 us |     1.0816 us |     2.0315 us |      53.596 us |
|         LinkedListCollection | FindFirst | Small |      25.409 us |     0.3998 us |     0.3338 us |      25.364 us |
|           **ListCollection** | FindFirst | Small |       8.417 us |     0.1309 us |     0.1224 us |       8.428 us |
|           ReadOnlyCollection | FindFirst | Small |       8.741 us |     0.1456 us |     0.2393 us |       8.672 us |
|||||||
|     ImmutableArrayCollection |  FindLast | Small |     462.810 us |     8.8284 us |    11.1651 us |     461.476 us |
|      ImmutableListCollection |  FindLast | Small |   5,034.331 us |    99.0277 us |   206.7078 us |   5,036.925 us |
|         LinkedListCollection |  FindLast | Small |   1,709.818 us |    34.1118 us |    36.4992 us |   1,711.116 us |
|           **ListCollection** |  FindLast | Small |     462.359 us |     9.1372 us |    14.7548 us |     464.668 us |
|           ReadOnlyCollection |  FindLast | Small |     941.481 us |    18.7418 us |    30.7933 us |     935.237 us |

|     ImmutableArrayCollection | FindFirst | Large |     128.537 us |     2.8581 us |     8.2462 us |     127.381 us |
|      ImmutableListCollection | FindFirst | Large |     819.627 us |    10.9593 us |    10.2514 us |     817.383 us |
|         LinkedListCollection | FindFirst | Large |     763.445 us |    15.2345 us |    38.4996 us |     746.063 us |
|               ListCollection | FindFirst | Large |     122.249 us |     2.6092 us |     7.5280 us |     120.468 us |
|       **ReadOnlyCollection** | FindFirst | Large |       8.540 us |     0.1413 us |     0.1253 us |       8.541 us |
|||||||
|     ImmutableArrayCollection |  FindLast | Large |  20,816.414 us |   407.7623 us |   597.6927 us |  20,563.897 us |
|      ImmutableListCollection |  FindLast | Large | 161,130.855 us | 1,242.6622 us | 1,101.5877 us | 161,122.837 us |
|         LinkedListCollection |  FindLast | Large |  58,239.692 us |   588.2697 us |   521.4858 us |  58,212.561 us |
|           **ListCollection** |  FindLast | Large |  19,221.029 us |   211.9653 us |   187.9017 us |  19,170.303 us |
|           ReadOnlyCollection |  FindLast | Large |  35,747.563 us |   630.2854 us |   903.9365 us |  35,385.618 us |

**Summary**

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1415 (21H2)
Intel Xeon Gold 6130 CPU 2.10GHz, 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT