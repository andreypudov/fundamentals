﻿// <copyright file="BubbleSortWithFlag.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting
{
    using System;

    /// <summary>
    /// Bubble sort, sometimes referred to as sinking sort, is a simple
    /// sorting algorithm that repeatedly steps through the list, compares
    /// adjacent elements and swaps them if they are in the wrong order.
    /// The pass through the list is repeated until the list is sorted.
    /// The algorithm, which is a comparison sort, is named for the way
    /// smaller or larger elements "bubble" to the top of the list.
    ///
    /// The implementation introduces a flag variable to stop the bubble sort
    /// as soon as it becomes sorted.
    /// </summary>
    public class BubbleSortWithFlag : ISort
    {
        /// <inheritdoc />
        public void Sort<T>(T[] array)
            where T : IComparable<T>
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            bool sorted = false;

            while (sorted == false)
            {
                sorted = true;

                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        T temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        sorted = false;
                    }
                }
            }
        }
    }
}