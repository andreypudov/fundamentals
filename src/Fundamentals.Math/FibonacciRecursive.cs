// <copyright file="FibonacciRecursive.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Represents an iterative implementation for <see cref="IFibonacci.Fibonacci(int)"/>.
    /// </summary>
    public class FibonacciRecursive : IFibonacci
    {
        /// <inheritdoc />
        public BigInteger Fibonacci(int position)
        {
            if (position < 0)
            {
                throw new ArgumentException(nameof(position));
            }

            if (position > short.MaxValue / 2)
            {
                return new FibonacciIterative().Fibonacci(position);
            }

            return Compute(position);
        }

        private static BigInteger Compute(int position) => position switch
        {
            0 => 0,
            1 => 1,
            _ => Compute(position - 1) + Compute(position - 2),
        };
    }
}
