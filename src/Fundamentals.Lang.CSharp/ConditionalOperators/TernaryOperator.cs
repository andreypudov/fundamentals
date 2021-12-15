// <copyright file="TernaryOperator.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ConditionalOperators;

/// <summary>
/// Represents a ternary operator.
/// </summary>
public class TernaryOperator : IConditionalOperator
{
    /// <inheritdoc />
    public string GetName(Color color)
    {
        return (color == Color.White) ? "White"
            : (color == Color.Silver) ? "Silver"
            : (color == Color.Gray) ? "Gray"
            : (color == Color.Black) ? "Black"
            : (color == Color.Red) ? "Red"
            : (color == Color.Maroon) ? "Maroon"
            : (color == Color.Yellow) ? "Yellow"
            : (color == Color.Olive) ? "Olive"
            : (color == Color.Lime) ? "Lime"
            : (color == Color.Green) ? "Green"
            : (color == Color.Aqua) ? "Aqua"
            : (color == Color.Teal) ? "Teal"
            : (color == Color.Blue) ? "Blue"
            : (color == Color.Navy) ? "Navy"
            : (color == Color.Fuchsia) ? "Fuchsia"
            : (color == Color.Purple) ? "Purple"
            : "None";
    }
}
