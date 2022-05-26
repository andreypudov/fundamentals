// <copyright file="CollectionCast.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;

/// <summary>
/// Represents a  benchmark for cast methods.
/// </summary>
public class CollectionCast
{
    /// <summary>
    /// Represents a benchmark for casting using <see cref="Enumerable.ToArray{T}"/> method.
    /// </summary>
    /// <param name="array">The enumeration of integer numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(CaseData))]
    public void ToArray(int[] array) =>
        _ = array.ToArray();

    /// <summary>
    /// Represents a benchmark for casting using <see cref="Enumerable.ToList{T}"/> method.
    /// </summary>
    /// <param name="array">The enumeration of integer numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(CaseData))]
    public void ToList(int[] array) =>
        _ = array.ToList();

    /// <summary>
    /// Represents a benchmark for casting using <see cref="Enumerable.ToHashSet{T}(IEnumerable{T})"/> method.
    /// </summary>
    /// <param name="array">The enumeration of integer numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(CaseData))]
    public void ToHashSet(int[] array) =>
        _ = array.ToHashSet();

    /// <summary>
    /// Represents a benchmark for casting using <see cref="ImmutableArray.ToImmutableArray{T}(IEnumerable{T})"/> method.
    /// </summary>
    /// <param name="array">The enumeration of integer numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(CaseData))]
    public void ToImmutableArray(int[] array) =>
        _ = array.ToImmutableArray();

    /// <summary>
    /// Represents a benchmark for casting using <see cref="ImmutableList.ToImmutableList{T}(IEnumerable{T})"/> method.
    /// </summary>
    /// <param name="array">The enumeration of integer numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(CaseData))]
    public void ToImmutableList(int[] array) =>
        _ = array.ToImmutableList();

    /// <summary>
    /// Represents a benchmark for casting using <see cref="ImmutableHashSet.ToImmutableHashSet{T}(IEnumerable{T})"/> method.
    /// </summary>
    /// <param name="array">The enumeration of integer numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(CaseData))]
    public void ToImmutableHashSet(int[] array) =>
        _ = array.ToImmutableHashSet();

    /// <summary>
    /// Represents a benchmark for casting using <see cref="ImmutableSortedSet.ToImmutableSortedSet{T}(IEnumerable{T})"/> method.
    /// </summary>
    /// <param name="array">The enumeration of integer numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(CaseData))]
    public void ToImmutableSortedSet(int[] array) =>
        _ = array.ToImmutableSortedSet();

    /// <summary>
    /// Represents a benchmark for casting using <see cref="List{T}.AsReadOnly"/> method.
    /// </summary>
    /// <param name="array">The enumeration of integer numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(CaseData))]
    public void ToReadOnly(int[] array) =>
        _ = array.ToList().AsReadOnly();

    /// <summary>
    /// Represents an enumeration of integer numbers.
    /// </summary>
    /// <returns>An enumeration of integer numbers.</returns>
    public IEnumerable<int[]> CaseData()
    {
        yield return Enumerable.Range(0, 16).ToArray();
        yield return Enumerable.Range(0, short.MaxValue).ToArray();
    }
}