// <copyright file="ForeachStatement.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.IterationStatements;

/// <summary>
/// Represents a <c>foreach</c> statement.
/// </summary>
public class ForeachStatement : IIterationStatement
{
    /// <inheritdoc />
    public int Sum(int[] numbers)
    {
        var sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    /// <inheritdoc />
    public int Sum(List<int> numbers)
    {
        var sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}