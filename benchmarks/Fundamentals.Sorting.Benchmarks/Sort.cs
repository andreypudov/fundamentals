﻿// <copyright file="Sort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting.Benchmarks;

using BenchmarkDotNet.Attributes;

/// <summary>
/// Represents a base benchmark for <see cref="Sorting"/>.
/// </summary>
/// <typeparam name="T">The type of the sort implementation.</typeparam>
public abstract class Sort<T>
    where T : ISort, new()
{
    private readonly T instance = new T();

    /// <summary>
    /// Represents a benchmark for ordered sequence.
    /// </summary>
    /// <param name="array">The source array to sort.</param>
    [Benchmark]
    [ArgumentsSource(nameof(BestCaseData))]
    public void BestCase(int[] array)
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        this.instance.Sort((int[])array.Clone());
    }

    /// <summary>
    /// Represents a benchmark for reversed sequence.
    /// </summary>
    /// <param name="array">The source array to sort.</param>
    [Benchmark]
    [ArgumentsSource(nameof(WorstCaseData))]
    public void WorstCase(int[] array)
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        this.instance.Sort((int[])array.Clone());
    }

    /// <summary>
    /// Represents an enumeration of arguments for best case benchmark.
    /// </summary>
    /// <returns>An enumeration of arguments for benchmarks.</returns>
    public IEnumerable<int[]> BestCaseData()
    {
        yield return Enumerable.Range(0, 16).ToArray();
        yield return Enumerable.Range(0, short.MaxValue).ToArray();
    }

    /// <summary>
    /// Represents an enumeration of arguments for worst case benchmark.
    /// </summary>
    /// <returns>An enumeration of arguments for benchmarks.</returns>
    public IEnumerable<int[]> WorstCaseData()
    {
        yield return Enumerable.Range(0, 16).Reverse().ToArray();
        yield return Enumerable.Range(0, short.MaxValue).Reverse().ToArray();
    }
}
