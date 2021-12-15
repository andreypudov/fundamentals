// <copyright file="FibonacciIterative.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math;

using System.Numerics;

/// <summary>
/// Represents an iterative implementation for <see cref="IFibonacci.Fibonacci(int)"/>.
/// </summary>
public class FibonacciIterative : IFibonacci
{
    /// <inheritdoc />
    public BigInteger Fibonacci(int position)
    {
        int previous = 0;
        int current = 1;

        if (position < 0)
        {
            throw new ArgumentException(nameof(position));
        }

        if (position == 0)
        {
            return 0;
        }

        for (int index = 2; index <= position; ++index)
        {
            int next = previous + current;
            previous = current;
            current = next;
        }

        return current;
    }
}
