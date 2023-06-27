// <copyright file="ForStatement.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.IterationStatements;

/// <summary>
/// Represents a <c>for</c> statement.
/// </summary>
public class ForStatement : IIterationStatement
{
    /// <inheritdoc />
    public int Sum(int[] numbers)
    {
        var sum = 0;

        for (var index = 0; index < numbers.Length; ++index)
        {
            sum += numbers[index];
        }

        return sum;
    }

    /// <inheritdoc />
    public int Sum(List<int> numbers)
    {
        var sum = 0;

        for (var index = 0; index < numbers.Count; ++index)
        {
            sum += numbers[index];
        }

        return sum;
    }
}