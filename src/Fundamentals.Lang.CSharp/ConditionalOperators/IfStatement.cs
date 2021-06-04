// <copyright file="IfStatement.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ConditionalOperators
{
    /// <summary>
    /// Represents an if condition statement.
    /// </summary>
    public class IfStatement : IConditionalOperator
    {
        /// <inheritdoc />
        public string GetName(Color color)
        {
            if (color == Color.White)
            {
                return "White";
            }
            else if (color == Color.Silver)
            {
                return "Silver";
            }
            else if (color == Color.Gray)
            {
                return "Gray";
            }
            else if (color == Color.Black)
            {
                return "Black";
            }
            else if (color == Color.Red)
            {
                return "Red";
            }
            else if (color == Color.Maroon)
            {
                return "Maroon";
            }
            else if (color == Color.Yellow)
            {
                return "Yellow";
            }
            else if (color == Color.Olive)
            {
                return "Olive";
            }
            else if (color == Color.Lime)
            {
                return "Lime";
            }
            else if (color == Color.Green)
            {
                return "Green";
            }
            else if (color == Color.Aqua)
            {
                return "Aqua";
            }
            else if (color == Color.Teal)
            {
                return "Teal";
            }
            else if (color == Color.Blue)
            {
                return "Blue";
            }
            else if (color == Color.Navy)
            {
                return "Navy";
            }
            else if (color == Color.Fuchsia)
            {
                return "Fuchsia";
            }
            else if (color == Color.Purple)
            {
                return "Purple";
            }
            else
            {
                return "None";
            }
        }
    }
}
