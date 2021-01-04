// <copyright file="FibonacciIterative.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math
{
    using System;
    using System.Numerics;

    /// <summary>
    /// Represents an iterative implementation for <see cref="IFibonacci.Fibonacci(int)"/>.
    /// </summary>
    public class FibonacciIterative : IFibonacci
    {
        /// <inheritdoc />
        public BigInteger Fibonacci(int position)
        {
            var first = new BigInteger(0);
            var second = new BigInteger(1);
            var result = new BigInteger(position);

            if (position < 0)
            {
                throw new ArgumentException(nameof(position));
            }

            for (int index = 2; index <= position; ++index)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }
    }
}
