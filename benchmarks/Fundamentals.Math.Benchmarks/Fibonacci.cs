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
    /// <typeparam name="T">The type of the <see cref="IFibonacci"/> implementation.</typeparam>
    public abstract class Fibonacci<T>
        where T : IFibonacci, new()
    {
        private readonly T instance = new T();

        /// <summary>
        /// Represents a general benchmark.
        /// </summary>
        /// <param name="position">The position of the number.</param>
        [Benchmark]
        [Arguments(16)]
        public void General(int position) =>
            this.instance.Fibonacci(position);
    }
}
