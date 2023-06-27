// <copyright file="IterationStatement.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Tests.IterationStatements;

using Fundamentals.Lang.CSharp.IterationStatements;
using NUnit.Framework;

/// <summary>
/// Represents a base test fixture for <see cref="IIterationStatement"/>.
/// </summary>
/// <typeparam name="T">The type of the <see cref="IIterationStatement"/> implementation.</typeparam>
[TestFixture]
public abstract class IterationStatement<T>
    where T : IIterationStatement, new()
{
    /// <summary>
    /// Represents a positive test case for the iteration statement.
    /// </summary>
    /// <param name="numbers">The collection of numbers.</param>
    /// <param name="sum">The sum of numbers.</param>
    [TestCase(new int[] { 0, 1, 2, 3 }, 6)]
    [TestCase(new int[] { -3, -2, -1, 0 }, -6)]
    [TestCase(new int[] { int.MaxValue }, int.MaxValue)]
    [TestCase(new int[] { int.MinValue }, int.MinValue)]
    public virtual void IterationStatement_PositiveSumOfArray_ReturnsSum(int[] numbers, int sum) =>
        Assert.AreEqual(sum, new T().Sum(numbers));

    /// <summary>
    /// Represents a positive test case for the iteration statement.
    /// </summary>
    /// <param name="numbers">The collection of numbers.</param>
    /// <param name="sum">The sum of numbers.</param>
    [TestCase(new int[] { 0, 1, 2, 3 }, 6)]
    [TestCase(new int[] { -3, -2, -1, 0 }, -6)]
    [TestCase(new int[] { int.MaxValue }, int.MaxValue)]
    [TestCase(new int[] { int.MinValue }, int.MinValue)]
    public void IterationStatement_PositiveSumOfList_ReturnsSum(int[] numbers, int sum) =>
        Assert.AreEqual(sum, new T().Sum(numbers.ToList()));
}