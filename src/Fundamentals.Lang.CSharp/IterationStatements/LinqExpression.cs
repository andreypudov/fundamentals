// <copyright file="LinqExpression.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.IterationStatements;

/// <summary>
/// Represents a LINQ expression.
/// </summary>
public class LinqExpression : IIterationStatement
{
    /// <inheritdoc />
    public int Sum(int[] numbers) => numbers.Sum();

    /// <inheritdoc />
    public int Sum(List<int> numbers) => numbers.Sum();
}