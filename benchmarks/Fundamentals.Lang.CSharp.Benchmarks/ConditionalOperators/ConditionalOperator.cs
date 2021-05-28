// <copyright file="ConditionalOperator.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.Benchmarks.ConditionalOperators
{
    using BenchmarkDotNet.Attributes;
    using Fundamentals.Lang.CSharp.ConditionalOperators;

    /// <summary>
    /// Represents a base benchmark for conditional operators./>.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="IConditionalOperator"/> implementation.</typeparam>
    public abstract class ConditionalOperator<T>
        where T : IConditionalOperator, new()
    {
        private readonly IConditionalOperator op = new T();

        /// <summary>
        /// Represents a positive test case for the conditional operator.
        /// </summary>
        /// <param name="color">The value of the color.</param>
        /// <returns>The name of the color.</returns>
        [Benchmark]
        [Arguments(Color.Purple)]
        public string General(Color color) =>
            this.op.GetName(color);
    }
}
