// <copyright file="Fibonacci.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Math.Tests
{
    using System;
    using System.Numerics;
    using NUnit.Framework;

    /// <summary>
    /// Represents a base test fixture for <see cref="IFibonacci"/>.
    /// </summary>
    /// <typeparam name="T">The type of the <see cref="IFibonacci"/> implementation.</typeparam>
    [TestFixture]
    public abstract class Fibonacci<T>
        where T : IFibonacci, new()
    {
        private readonly BigInteger zero = 0;
        private readonly BigInteger one = 1;
        private readonly BigInteger shortMax = BigInteger.Parse(Resources.Math.Fibonacci.ShortMax);
        private readonly BigInteger intMax = BigInteger.Parse(Resources.Math.Fibonacci.IntMax8192);

        /// <summary>
        /// Represents a positive test case for the first number.
        /// </summary>
        [Test]
        public void Fibonacci_First_ReturnsFirst() =>
            Assert.AreEqual(this.zero, new T().Fibonacci(0));

        /// <summary>
        /// Represents a positive test case for the second number.
        /// </summary>
        [Test]
        public void Fibonacci_Second_ReturnsSecond() =>
            Assert.AreEqual(this.one, new T().Fibonacci(1));

        /// <summary>
        /// Represents a positive test case for the maximum value of shot data type.
        /// </summary>
        [Test]
        public void Fibonacci_ShortMax_ReturnsSecond() =>
            Assert.AreEqual(this.shortMax, new T().Fibonacci(short.MaxValue));

        /// <summary>
        /// Represents a positive test case for the maximum value of integer data type.
        /// </summary>
        [Test]
        public void Fibonacci_IntMax_ReturnsSecond() =>
            Assert.AreEqual(this.intMax, new T().Fibonacci(int.MaxValue / 8192));

        /// <summary>
        /// Represents a negative test case for the negative number.
        /// </summary>
        [Test]
        public void Fibonacci_NegativePosition_ThrowsArgumentException() =>
            Assert.Throws<ArgumentException>(() => new T().Fibonacci(-1));
    }
}
