// <copyright file="FibonacciTailRecursive.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Represents an tail recursive implementation for <see cref="IFibonacci.Fibonacci(int)"/>.
    /// </summary>
    public class FibonacciTailRecursive : IFibonacci
    {
        /// <inheritdoc />
        public BigInteger Fibonacci(int position)
        {
            if (position < 0)
            {
                throw new ArgumentException(nameof(position));
            }

            if (position == 0)
            {
                return 0;
            }

            return Compute(0, 1, position - 1);
        }

        private static BigInteger Compute(int previous, int current, int position) => position switch
        {
            0 => current,
            _ => Compute(current, previous + current, position - 1),
        };
    }
}