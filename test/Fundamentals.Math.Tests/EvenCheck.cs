// <copyright file="EvenCheck.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math.Tests;

using NUnit.Framework;

/// <summary>
/// Represents a base test fixture for <see cref="IEvenCheck"/>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="IEvenCheck"/> implementation.</typeparam>
[TestFixture]
public abstract class EvenCheck<T>
    where T : IEvenCheck, new()
{
    /// <summary>
    /// Represents a test case for zero.
    /// </summary>
    [Test]
    public void IsEven_Zero_ReturnsTrue() =>
        Assert.IsTrue(new T().IsEven(0));

    /// <summary>
    /// Represents a test case for one.
    /// </summary>
    [Test]
    public void IsEven_One_ReturnsFalse() =>
        Assert.IsFalse(new T().IsEven(1));

    /// <summary>
    /// Represents a test case for two.
    /// </summary>
    [Test]
    public void IsEven_Two_ReturnsTrue() =>
        Assert.IsTrue(new T().IsEven(2));

    /// <summary>
    /// Represents a test case for max value.
    /// </summary>
    [Test]
    public void IsEven_Min_ReturnsTrue() =>
        Assert.IsTrue(new T().IsEven(int.MinValue));

    /// <summary>
    /// Represents a test case for max value.
    /// </summary>
    [Test]
    public void IsEven_Max_ReturnsFalse() =>
        Assert.IsFalse(new T().IsEven(int.MaxValue));
}
