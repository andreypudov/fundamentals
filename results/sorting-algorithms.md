## Sorting algorithms

|                   Type |    Method |        array |               Mean |            Error |           StdDev |           Median |
|----------------------- |---------- |------------- |-------------------:|-----------------:|-----------------:|-----------------:|
|             BubbleSort |  BestCase |    Int32[16] |           251.2 ns |          4.94 ns |          5.69 ns |         249.2 ns |
| **BubbleSortWithFlag** |  BestCase |    Int32[16] |       **121.5 ns** |          1.43 ns |          1.27 ns |         121.2 ns |
|               HeapSort |  BestCase |    Int32[16] |           326.6 ns |          4.80 ns |          4.01 ns |         325.3 ns |
|          InsertionSort |  BestCase |    Int32[16] |           187.1 ns |         10.22 ns |         28.49 ns |         190.9 ns |
|              MergeSort |  BestCase |    Int32[16] |           449.6 ns |          7.59 ns |          6.34 ns |         449.5 ns |
|              QuickSort |  BestCase |    Int32[16] |           190.5 ns |          2.16 ns |          1.80 ns |         190.8 ns |
|     QuickSortDualPivot |  BestCase |    Int32[16] |           274.2 ns |          2.94 ns |          2.60 ns |         273.1 ns |
|              RadixSort |  BestCase |    Int32[16] |         1,376.6 ns |         26.09 ns |         44.31 ns |       1,365.7 ns |
|          SelectionSort |  BestCase |    Int32[16] |           298.2 ns |          5.85 ns |          8.57 ns |         294.1 ns |
|        SystemArraySort |  BestCase |    Int32[16] |           139.5 ns |          4.55 ns |         12.91 ns |         134.8 ns |
|||||||
|             BubbleSort | WorstCase |    Int32[16] |           243.1 ns |          4.86 ns |          9.25 ns |         239.7 ns |
|     BubbleSortWithFlag | WorstCase |    Int32[16] |           332.0 ns |          6.62 ns |          8.13 ns |         328.9 ns |
|               HeapSort | WorstCase |    Int32[16] |           292.3 ns |          5.38 ns |          6.20 ns |         290.6 ns |
|          InsertionSort | WorstCase |    Int32[16] |           269.3 ns |          5.35 ns |         12.30 ns |         263.4 ns |
|              MergeSort | WorstCase |    Int32[16] |           450.0 ns |          7.93 ns |         12.11 ns |         445.4 ns |
|          **QuickSort** | WorstCase |    Int32[16] |       **200.4 ns** |          4.04 ns |          3.97 ns |         199.3 ns |
|     QuickSortDualPivot | WorstCase |    Int32[16] |           262.1 ns |          1.93 ns |          1.71 ns |         262.0 ns |
|              RadixSort | WorstCase |    Int32[16] |         1,323.7 ns |         25.15 ns |         27.95 ns |       1,318.2 ns |
|          SelectionSort | WorstCase |    Int32[16] |           249.7 ns |          4.80 ns |          4.72 ns |         248.3 ns |
|        SystemArraySort | WorstCase |    Int32[16] |           230.7 ns |          4.51 ns |         11.15 ns |         227.5 ns |
|||||||
|             BubbleSort |  BestCase | Int32[32767] |   564,673,861.5 ns |  9,633,067.16 ns |  8,044,047.36 ns | 564,947,700.0 ns |
| **BubbleSortWithFlag** |  BestCase | Int32[32767] |    **85,323.3 ns** |      1,702.63 ns |      2,441.86 ns |      85,493.8 ns |
|               HeapSort |  BestCase | Int32[32767] |     2,689,166.9 ns |     45,260.31 ns |     40,122.09 ns |   2,672,935.4 ns |
|          InsertionSort |  BestCase | Int32[32767] |       116,159.8 ns |      2,293.66 ns |      4,685.34 ns |     115,090.9 ns |
|              MergeSort |  BestCase | Int32[32767] |     1,747,253.2 ns |     34,826.71 ns |     46,492.66 ns |   1,733,398.4 ns |
|              QuickSort |  BestCase | Int32[32767] |       669,083.2 ns |     12,892.99 ns |     11,429.30 ns |     665,939.1 ns |
|     QuickSortDualPivot |  BestCase | Int32[32767] |   440,986,300.0 ns |  4,364,975.57 ns |  3,407,885.81 ns | 439,952,800.0 ns |
|              RadixSort |  BestCase | Int32[32767] |     1,978,051.6 ns |     39,128.41 ns |     56,116.79 ns |   1,960,058.4 ns |
|          SelectionSort |  BestCase | Int32[32767] |   425,003,676.9 ns |  1,882,948.45 ns |  1,572,347.23 ns | 425,557,100.0 ns |
|        SystemArraySort |  BestCase | Int32[32767] |       280,252.5 ns |      4,718.93 ns |      4,414.09 ns |     279,982.3 ns |
|||||||
|             BubbleSort | WorstCase | Int32[32767] |   570,137,628.6 ns |  8,983,228.08 ns |  7,963,397.71 ns | 568,422,050.0 ns |
|     BubbleSortWithFlag | WorstCase | Int32[32767] | 1,009,222,672.0 ns | 19,728,192.15 ns | 26,336,569.87 ns | 996,401,600.0 ns |
|               HeapSort | WorstCase | Int32[32767] |     2,955,646.7 ns |    111,140.79 ns |    327,701.12 ns |   2,764,615.4 ns |
|          InsertionSort | WorstCase | Int32[32767] |   604,236,800.0 ns |  6,581,047.42 ns |  5,495,472.65 ns | 600,669,000.0 ns |
|              MergeSort | WorstCase | Int32[32767] |     1,673,416.8 ns |     30,105.19 ns |     25,139.20 ns |   1,675,587.9 ns |
|              QuickSort | WorstCase | Int32[32767] |       556,126.3 ns |      7,484.30 ns |      6,634.64 ns |     554,901.8 ns |
|     QuickSortDualPivot | WorstCase | Int32[32767] |   277,764,933.3 ns |  5,205,041.77 ns |  4,868,799.30 ns | 277,551,200.0 ns |
|              RadixSort | WorstCase | Int32[32767] |     2,031,702.3 ns |     40,525.69 ns |     85,482.45 ns |   1,996,088.3 ns |
|          SelectionSort | WorstCase | Int32[32767] |   383,472,083.3 ns |  1,902,940.09 ns |  1,485,690.45 ns | 383,576,850.0 ns |
|    **SystemArraySort** | WorstCase | Int32[32767] |   **426,139.2 ns** |      8,377.62 ns |      6,995.69 ns |     425,500.0 ns |


**Summary**

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.685 (2004/?/20H1)<br>
Intel Core i5-8365U CPU 1.60GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores<br>
.NET Core SDK=5.0.101<br>
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT<br>
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT<br>

**Legends**

array  : Value of the 'array' parameter<br>
Mean   : Arithmetic mean of all measurements<br>
Error  : Half of 99.9% confidence interval<br>
StdDev : Standard deviation of all measurements<br>
Median : Value separating the higher half of all measurements (50th percentile)<br>
1 ns   : 1 Nanosecond (0.000000001 sec)<br>