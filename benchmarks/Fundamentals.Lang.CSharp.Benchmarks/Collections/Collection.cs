// <copyright file="Collection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

using BenchmarkDotNet.Attributes;
using Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Represents a base benchmark for collections./>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="ICollection{TCollection, T}"/> implementation.</typeparam>
/// <typeparam name="TCollection">The type of the coolection.</typeparam>
public abstract class Collection<T, TCollection>
    where T : ICollection<TCollection, string>, new()
{
    private const int NumberOfIterations = 128;

    private static readonly string ItemValue = string.Join(string.Empty, Enumerable.Range(1, 32).ToArray());

    private readonly T instance = new();

    /// <summary>
    /// Gets the small collection of items.
    /// </summary>
    public abstract TCollection EmptyCollection { get; }

    /// <summary>
    /// Represents a benchmark for adding the element to the small collection.
    /// </summary>
    [Benchmark]
    public void AddToEmptyCollection()
    {
        var emptyColleciton = this.EmptyCollection;

        for (int iteration = 0; iteration < NumberOfIterations; ++iteration)
        {
            this.instance.Add(emptyColleciton, $"{iteration}");
        }
    }
}
