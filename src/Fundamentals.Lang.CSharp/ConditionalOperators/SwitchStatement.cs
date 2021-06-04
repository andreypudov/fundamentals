// <copyright file="SwitchStatement.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ConditionalOperators
{
    /// <summary>
    /// Represents a switch statement.
    /// </summary>
    public class SwitchStatement : IConditionalOperator
    {
        /// <inheritdoc />
        public string GetName(Color color)
        {
            switch (color)
            {
                case Color.White:
                    return "White";
                case Color.Silver:
                    return "Silver";
                case Color.Gray:
                    return "Gray";
                case Color.Black:
                    return "Black";
                case Color.Red:
                    return "Red";
                case Color.Maroon:
                    return "Maroon";
                case Color.Yellow:
                    return "Yellow";
                case Color.Olive:
                    return "Olive";
                case Color.Lime:
                    return "Lime";
                case Color.Green:
                    return "Green";
                case Color.Aqua:
                    return "Aqua";
                case Color.Teal:
                    return "Teal";
                case Color.Blue:
                    return "Blue";
                case Color.Navy:
                    return "Navy";
                case Color.Fuchsia:
                    return "Fuchsia";
                case Color.Purple:
                    return "Purple";
                default:
                    return "None";
            }
        }
    }
}