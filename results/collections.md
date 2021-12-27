## Collections

|                    Type |    Method |  type |          Mean |        Error |       StdDev |        Median |
|------------------------ |---------- |------ |--------------:|-------------:|-------------:|--------------:|
| ImmutableListCollection | FindFirst | Small |      56.72 us |     1.129 us |     2.093 us |      56.16 us |
|    LinkedListCollection | FindFirst | Small |      30.81 us |     0.611 us |     1.132 us |      30.31 us |
|          ListCollection | FindFirst | Small |      11.35 us |     0.224 us |     0.457 us |      11.27 us |
|  **ReadOnlyCollection** | FindFirst | Small |      10.24 us |     0.204 us |     0.481 us |      10.11 us |
||||||||
| ImmutableListCollection |  FindLast | Small |   5,561.58 us |    47.690 us |    44.609 us |   5,560.48 us |
|    LinkedListCollection |  FindLast | Small |   1,727.99 us |    11.171 us |     9.903 us |   1,727.42 us |
|          ListCollection |  FindLast | Small |   1,451.81 us |    20.072 us |    18.775 us |   1,450.28 us |
|  **ReadOnlyCollection** |  FindLast | Small |     941.09 us |    18.728 us |    34.245 us |     926.38 us |
||||||||
| ImmutableListCollection | FindFirst | Large |     937.76 us |    18.599 us |    47.003 us |     927.67 us |
|    LinkedListCollection | FindFirst | Large |     827.85 us |     8.230 us |     6.426 us |     826.67 us |
|          ListCollection | FindFirst | Large |     170.85 us |     2.948 us |     2.613 us |     171.52 us |
|  **ReadOnlyCollection** | FindFirst | Large |      10.84 us |     0.177 us |     0.157 us |      10.86 us |
||||||||
| ImmutableListCollection |  FindLast | Large | 197,902.18 us | 1,992.840 us | 1,664.112 us | 197,908.40 us |
|    LinkedListCollection |  FindLast | Large |  61,102.02 us |   623.968 us |   742.789 us |  60,846.40 us |
|          ListCollection |  FindLast | Large |  54,063.13 us | 1,070.636 us | 2,062.752 us |  53,049.68 us |
|  **ReadOnlyCollection** |  FindLast | Large |  35,078.01 us |   689.661 us |   944.016 us |  34,686.54 us |

**Summary**

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1415 (21H2)<br>
Intel Core i7-10850H CPU 2.70GHz, 1 CPU, 12 logical and 6 physical cores<br>
.NET SDK=6.0.101<br>
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT<br>
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT<br>