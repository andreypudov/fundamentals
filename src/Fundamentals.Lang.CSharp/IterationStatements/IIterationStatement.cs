// <copyright file="IIterationStatement.cs" company="Andrey Pudov">
// Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.IterationStatements;

/// <summary>
/// Exposes an operator that provides the iteration statement.
/// </summary>
public interface IIterationStatement
{
    /// <summary>
    /// Calculates the sum of given numbers.
    /// </summary>
    /// <param name="numbers">The collection of numbers.</param>
    /// <returns>The sum of given numbers.</returns>
    int Sum(int[] numbers);

    /// <summary>
    /// Calculates the sum of given numbers.
    /// </summary>
    /// <param name="numbers">The collection of numbers.</param>
    /// <returns>The sum of given numbers.</returns>
    int Sum(List<int> numbers);
}