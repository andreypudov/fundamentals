﻿// <copyright file="Collection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.Collections;

using BenchmarkDotNet.Attributes;
using Fundamentals.Lang.CSharp.Benchmarks.Core;
using Fundamentals.Lang.CSharp.Collections;

/// <summary>
/// Represents a base benchmark for <see cref="ICollection{TCollection, T}"/>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="ICollection{TCollection, T}"/> implementation.</typeparam>
/// <typeparam name="TCollection">The type of the collection.</typeparam>
public abstract class Collection<T, TCollection>
    where T : ICollection<TCollection, string>, new()
    where TCollection : System.Collections.ICollection
{
    /// <summary>
    /// The data for the small collection.
    /// </summary>
    public static readonly string[] SmallData = Enumerable.Range(1, (int)Math.Pow(2, 10)).Select(i => $"{i}").ToArray();

    /// <summary>
    /// The data for the large collection.
    /// </summary>
    public static readonly string[] LargeData = Enumerable.Range(1, (int)Math.Pow(2, 15)).Select(i => $"{i}").ToArray();

    private readonly T instance = new();

    /// <summary>
    /// Gets the small collection of items.
    /// </summary>
    public abstract TCollection SmallCollection { get; }

    /// <summary>
    /// Gets the large collection of items.
    /// </summary>
    public abstract TCollection LargeCollection { get; }

    /// <summary>
    /// Represents a benchmark for finding the fist element in the given collection.
    /// </summary>
    /// <param name="type">The type of the collection.</param>
    [Benchmark]
    [Arguments(CollectionType.Small)]
    [Arguments(CollectionType.Large)]
    public void Add(CollectionType type) =>
        this.instance.Add(this.GetCollection(type), $"{int.MaxValue}");

    /// <summary>
    /// Represents a benchmark for finding the fist element in the given collection.
    /// </summary>
    /// <param name="type">The type of the collection.</param>
    [Benchmark]
    [Arguments(CollectionType.Small)]
    [Arguments(CollectionType.Large)]
    public void FindFirst(CollectionType type) =>
        this.instance.Find(this.GetCollection(type), $"{1}");

        /// <summary>
    /// Represents a benchmark for finding the fist element in the given collection.
    /// </summary>
    /// <param name="type">The type of the collection.</param>
    [Benchmark]
    [Arguments(CollectionType.Small)]
    [Arguments(CollectionType.Large)]
    public void FindMiddle(CollectionType type) =>
            this.instance.Find(this.GetCollection(type), $"{this.GetCount(type) / 2}");

        /// <summary>
    /// Represents a benchmark for finding the last element in the given collection.
    /// </summary>
    /// <param name="type">The type of the collection.</param>
    [Benchmark]
    [Arguments(CollectionType.Small)]
    [Arguments(CollectionType.Large)]
    public void FindLast(CollectionType type) =>
            this.instance.Find(this.GetCollection(type), $"{this.GetCount(type) - 1}");

        /// <summary>
    /// Represents a benchmark for filtering the even elements from the given collection.
    /// </summary>
    /// <param name="type">The type of the collection.</param>
    [Benchmark]
    [Arguments(CollectionType.Small)]
    [Arguments(CollectionType.Large)]
    public void Filter(CollectionType type)
    {
        var collection = this.GetCollection(type);
        static bool Predicate(string item) => item.Length % 2 == 0;

        this.instance.Filter(this.GetCollection(type), Predicate);
    }

    private TCollection GetCollection(CollectionType type) => type switch
    {
        CollectionType.Small => this.SmallCollection,
        CollectionType.Large => this.LargeCollection,
        _ => throw new ArgumentOutOfRangeException(nameof(type), $"Not expected collection type: {type}"),
    };

    private int GetCount(CollectionType type) => type switch
    {
        CollectionType.Small => this.SmallCollection.Count,
        CollectionType.Large => this.LargeCollection.Count,
        _ => throw new ArgumentOutOfRangeException(nameof(type), $"Not expected collection type: {type}"),
    };
}
