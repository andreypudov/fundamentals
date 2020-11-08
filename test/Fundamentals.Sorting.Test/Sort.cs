// <copyright file="Sort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting.Test
{
    using System;
    using System.Linq;
    using NUnit.Framework;

    /// <summary>
    /// Represents a base test fixture for <see cref="Sorting"/>.
    /// </summary>
    /// <typeparam name="T">The type of the sort implementation.</typeparam>
    [TestFixture]
    public abstract class Sort<T>
        where T : ISort, new()
    {
        /// <summary>
        /// Represents a positive test case for ordered sequence.
        /// </summary>
        [Test]
        public void Sort_Ordered_ReturnsSameSequence()
        {
            var actual = Enumerable.Range(0, 10).ToArray();
            var expected = (int[])actual.Clone();

            var sort = new T();

            Array.Sort(expected);
            sort.Sort(actual);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Represents a positive test case for reversed sequence.
        /// </summary>
        [Test]
        public void Sort_Reversed_ReturnsOrderedSequence()
        {
            var actual = Enumerable.Range(0, 10).Reverse().ToArray();
            var expected = (int[])actual.Clone();

            var sort = new T();

            Array.Sort(expected);
            sort.Sort(actual);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Represents a positive test case for reversed sequence.
        /// </summary>
        [Test]
        public void Sort_Null_ThrowsArgumentNullException()
        {
            var sort = new T();

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.Throws<ArgumentNullException>(() => sort.Sort<string>(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }
    }
}
