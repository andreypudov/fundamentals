// <copyright file="MergeSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    /// <summary>
    /// Represents a benchmark for <see cref="Sorting.MergeSort"/>.
    /// </summary>
    [SimpleJob(launchCount: 10, warmupCount: 10, targetCount: 10)]
    public class MergeSort : Sort<Sorting.MergeSort>
    {
        // Intentionally left bank
    }
}