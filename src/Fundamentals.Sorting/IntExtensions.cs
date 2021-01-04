// <copyright file="IntExtensions.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Sorting
{
    /// <summary>
    /// Provides extension methods for integer type.
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Unsigned right shift.
        /// </summary>
        /// <param name="value">The original integer value.</param>
        /// <param name="digits">The number of digits to shoft.</param>
        /// <returns>The value with number of digits shifted right.</returns>
        public static int Shift(this int value, int digits)
        {
            return (int)((uint)value >> digits);
        }
    }
}
