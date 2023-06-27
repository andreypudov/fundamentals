// <copyright file="DoStatement.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.IterationStatements;

/// <summary>
/// Represents a <c>do</c> statement.
/// </summary>
public class DoStatement : IIterationStatement
{
    /// <inheritdoc />
    public int Sum(int[] numbers)
    {
        var sum = 0;
        var index = 0;

        do
        {
            sum += numbers[index];
            ++index;
        }
        while (index < numbers.Length);

        return sum;
    }

    /// <inheritdoc />
    public int Sum(List<int> numbers)
    {
        var sum = 0;
        var index = 0;

        do
        {
            sum += numbers[index];
            ++index;
        }
        while (index < numbers.Count);

        return sum;
    }
}