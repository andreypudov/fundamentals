// <copyright file="InsertionSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting.Benchmark
{
    using BenchmarkDotNet.Attributes;

    /// <summary>
    /// Represents a benchmark for <see cref="Sorting.InsertionSort"/>.
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        /// Represents a positive benchmark for <see cref="Sorting.InsertionSort.Sort{T}(T[])"/> method.
        /// </summary>
        [Benchmark]
        public void SortWorstCasePositive()
        {
            var worst = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            var sort = new Sorting.InsertionSort();

            sort.Sort(worst);
        }
    }
}