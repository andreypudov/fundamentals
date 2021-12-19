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
/// <typeparam name="TItem">The type of elements in the coolection.</typeparam>
public abstract class Collection<T, TCollection, TItem>
    where T : ICollection<TCollection, TItem>, new()
{
    private readonly T instance = new T();

    /// <summary>
    /// Gets or sets the small collection of items.
    /// </summary>
    public abstract TCollection SmallCollection { get; set; }

    /// <summary>
    /// Represents a benchmark for adding the element to the collection.
    /// </summary>
    /// <param name="item">The item to be added to the end of the collection.</param>
    /// <returns>The new collection with the object added.</returns>
    [Benchmark]
    [Arguments(Color.White)]
    public TCollection Add(TItem item) =>
        this.instance.Add(this.SmallCollection, item);
}
