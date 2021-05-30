// <copyright file="MultipleIfStatements.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ConditionalOperators
{
    /// <summary>
    /// Represents an if condition operator./>.
    /// </summary>
    public class MultipleIfStatements : IConditionalOperator
    {
        /// <inheritdoc />
        public string GetName(Color color)
        {
            if (color == Color.White)
            {
                return "White";
            }

            if (color == Color.Silver)
            {
                return "Silver";
            }

            if (color == Color.Gray)
            {
                return "Gray";
            }

            if (color == Color.Black)
            {
                return "Black";
            }

            if (color == Color.Red)
            {
                return "Red";
            }

            if (color == Color.Maroon)
            {
                return "Maroon";
            }

            if (color == Color.Yellow)
            {
                return "Yellow";
            }

            if (color == Color.Olive)
            {
                return "Olive";
            }

            if (color == Color.Lime)
            {
                return "Lime";
            }

            if (color == Color.Green)
            {
                return "Green";
            }

            if (color == Color.Aqua)
            {
                return "Aqua";
            }

            if (color == Color.Teal)
            {
                return "Teal";
            }

            if (color == Color.Blue)
            {
                return "Blue";
            }

            if (color == Color.Navy)
            {
                return "Navy";
            }

            if (color == Color.Fuchsia)
            {
                return "Fuchsia";
            }

            if (color == Color.Purple)
            {
                return "Purple";
            }

            return "None";
        }
    }
}
