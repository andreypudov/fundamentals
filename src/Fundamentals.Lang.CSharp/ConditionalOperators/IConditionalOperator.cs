// <copyright file="IConditionalOperator.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ConditionalOperators
{
    /// <summary>
    /// Exposes an operator that provides the conditional execution.
    /// </summary>
    public interface IConditionalOperator
    {
        /// <summary>
        /// Returns the name of the given color.
        /// </summary>
        /// <param name="color">The instance of the color.</param>
        /// <returns>The name of the given color.</returns>
        string GetName(Color color);
    }
}