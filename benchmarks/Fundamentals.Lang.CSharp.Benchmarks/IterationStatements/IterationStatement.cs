// <copyright file="IterationStatement.cs" company="Andrey Pudov">
// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.IterationStatements;

using BenchmarkDotNet.Attributes;
using Fundamentals.Lang.CSharp.IterationStatements;

/// <summary>
/// Represents a base benchmark for <see cref="IIterationStatement"/>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="IIterationStatement"/> implementation.</typeparam>
public abstract class IterationStatement<T>
    where T : IIterationStatement, new()
{
    private readonly T instance = new T();

    /// <summary>
    /// The data.
    /// </summary>
    /// <returns>The enumerable data.</returns>
    public IEnumerable<int[]> Data()
    {
        yield return Enumerable.Range(1, (int)Math.Pow(2, 10)).ToArray();
        yield return Enumerable.Range(1, (int)Math.Pow(2, 14)).ToArray();
    }

    /// <summary>
    /// Represents a benchmark for the iteration statement using array.
    /// </summary>
    /// <param name="numbers">The collection of numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public virtual void SumOfArray(int[] numbers) => this.instance.Sum(numbers);

    /// <summary>
    /// Represents a benchmark for the iteration statement using List.
    /// </summary>
    /// <param name="numbers">The collection of numbers.</param>
    [Benchmark]
    [ArgumentsSource(nameof(Data))]
    public void SumOfList(int[] numbers) => this.instance.Sum(numbers.ToList());
}