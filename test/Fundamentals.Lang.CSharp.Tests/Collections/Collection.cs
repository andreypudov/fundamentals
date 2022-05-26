// <copyright file="Collection.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.Collections;

using Fundamentals.Lang.CSharp.Collections;
using NUnit.Framework;

/// <summary>
/// Represents a base test fixture for <see cref="ICollection{TCollection, T}"/>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="ICollection{TCollection, T}"/> implementation.</typeparam>
/// <typeparam name="TCollection">The type of the collection.</typeparam>
[TestFixture]
public abstract class Collection<T, TCollection>
    where T : ICollection<TCollection, string>, new()
    where TCollection : System.Collections.ICollection, IEnumerable<string>
{
    private readonly T instance = new();

    /// <summary>
    /// Represents a positive test case for adding a value to the collection.
    /// </summary>
    [Test]
    public void Add_AddToEnd_ReturnsCollectionWithValue()
    {
        var actual = this.instance.Build(new string[] { });
        var expected = this.instance.Build(new[] { "alpha", "beta", "gamma" });

        actual = this.instance.Add(actual, "alpha");
        actual = this.instance.Add(actual, "beta");
        actual = this.instance.Add(actual, "gamma");

        Assert.IsTrue(expected.SequenceEqual(actual));
    }

    /// <summary>
    /// Represents a positive test case for finding a value in the collection.
    /// </summary>
    /// <param name="value">The value to find in the collection.</param>
    [TestCase("alpha")]
    [TestCase("beta")]
    [TestCase("gamma")]
    public void Find_FindValue_ReturnsGivenValue(string value)
    {
        var collection = this.instance.Build(new[] { "alpha", "beta", "gamma" });

        Assert.AreEqual(value, this.instance.Find(collection, value));
    }

    /// <summary>
    /// Represents a positive test case for filtering the collection.
    /// </summary>
    [Test]
    public void Filter_FilterEven_ReturnsCollectionWithEvenNumbers()
    {
        var collection = this.instance.Build(new[] { "alpha", "beta", "gamma" });
        var expected = this.instance.Build(new[] { "beta" });

        Assert.IsTrue(expected.SequenceEqual(this.instance.Filter(collection, item => item.Length % 2 == 0)));
    }
}
