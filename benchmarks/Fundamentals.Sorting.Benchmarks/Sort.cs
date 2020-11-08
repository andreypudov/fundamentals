// <copyright file="Sort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting.Benchmarks
{
    using System.Collections.Generic;
    using System.Linq;
    using BenchmarkDotNet.Attributes;

    /// <summary>
    /// Represents a base benchmark for <see cref="Sorting"/>.
    /// </summary>
    /// <typeparam name="T">The type of the sort implementation.</typeparam>
    public abstract class Sort<T>
        where T : ISort, new()
    {
        /// <summary>
        /// Represents a positive test case for ordered sequence.
        /// </summary>
        /// <param name="array">The source array to sort.</param>
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public void BestCase(int[] array)
        {
            var sort = new T();
            sort.Sort(array);
        }

        /// <summary>
        /// Represents an enumeration of arguments for benchmarks.
        /// </summary>
        /// <returns>An enumeration of arguments for benchmarks.</returns>
        public IEnumerable<int[]> Data()
        {
            yield return Enumerable.Range(0, 16).ToArray();
            yield return Enumerable.Range(0, short.MaxValue).ToArray();
        }
    }
}
