// <copyright file="MergeSort.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting;

/// <summary>
/// In computer science, merge sort (also commonly spelled mergesort) is
/// an efficient, general-purpose, comparison-based sorting algorithm.
/// Most implementations produce a stable sort, which means that the order
/// of equal elements is the same in the input and output. Merge sort is
/// a divide and conquer algorithm that was invented by John von Neumann
/// in 1945. A detailed description and analysis of bottom-up mergesort
/// appeared in a report by Goldstine and von Neumann as early as 1948.
/// </summary>
public class MergeSort : ISort
{
    /// <inheritdoc />
    public void Sort<T>(T[] array)
        where T : IComparable<T>
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        Sort(array, 0, array.Length - 1);
    }

    private static void Sort<T>(T[] array, int left, int right)
        where T : IComparable<T>
    {
        if (left < right)
        {
            int middle = left + ((right - left) / 2);

            Sort(array, left, middle);
            Sort(array, middle + 1, right);
            Merge(array, left, middle, right);
        }
    }

    private static void Merge<T>(T[] array, int left, int middle, int right)
        where T : IComparable<T>
    {
        int leftSize = middle - left + 1;
        int rightSize = right - middle;

        T[] leftArray = new T[leftSize];
        T[] rightArray = new T[rightSize];

        for (int index = 0; index < leftSize; ++index)
        {
            leftArray[index] = array[left + index];
        }

        for (int index = 0; index < rightSize; ++index)
        {
            rightArray[index] = array[middle + index + 1];
        }

        int leftIndex = 0;
        int rightIndex = 0;
        int current = left;

        while ((leftIndex < leftSize) && (rightIndex < rightSize))
        {
            if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
            {
                array[current] = leftArray[leftIndex];
                leftIndex = leftIndex + 1;
            }
            else if (rightIndex < rightSize)
            {
                array[current] = rightArray[rightIndex];
                rightIndex = rightIndex + 1;
            }

            current = current + 1;
        }

        while (leftIndex < leftSize)
        {
            array[current] = leftArray[leftIndex];
            leftIndex = leftIndex + 1;
            current = current + 1;
        }

        while (rightIndex < rightSize)
        {
            array[current] = rightArray[rightIndex];
            rightIndex = rightIndex + 1;
            current = current + 1;
        }
    }
}
