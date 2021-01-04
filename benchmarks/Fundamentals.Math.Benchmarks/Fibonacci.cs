// <copyright file="Fibonacci.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math.Benchmarks
{
    using BenchmarkDotNet.Attributes;
    using Fundamentals.Math;

    /// <summary>
    /// Represents a base benchmark for <see cref="IFibonacci"/>.
    /// </summary>
    /// <typeparam name="T">The type of the sort implementation.</typeparam>
    public abstract class Fibonacci<T>
        where T : IFibonacci, new()
    {
        private readonly IFibonacci fibonacci = new T();

        /// <summary>
        /// Represents a positive test case for reversed sequence.
        /// </summary>
        /// <param name="position">The position of the number.</param>
        [Benchmark]
        [Arguments(16)]
        [Arguments(short.MaxValue / 2)]
        [Arguments(int.MaxValue / 8192)]
        public void General(int position) =>
            this.fibonacci.Fibonacci(position);
    }
}
