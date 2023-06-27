// <copyright file="WhileStatement.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.IterationStatements;

/// <summary>
/// Represents a <c>while</c> statement.
/// </summary>
public class WhileStatement : IIterationStatement
{
    /// <inheritdoc />
    public int Sum(int[] numbers)
    {
        var sum = 0;
        var index = 0;

        while (index < numbers.Length)
        {
            sum += numbers[index];
            ++index;
        }

        return sum;
    }

    /// <inheritdoc />
    public int Sum(List<int> numbers)
    {
        var sum = 0;
        var index = 0;

        while (index < numbers.Count)
        {
            sum += numbers[index];
            ++index;
        }

        return sum;
    }
}