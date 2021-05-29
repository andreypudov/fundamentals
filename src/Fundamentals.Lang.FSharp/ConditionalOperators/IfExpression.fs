// <copyright file="IfExpression.fs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.FSharp.ConditionalOperators

open Fundamentals.Lang.FSharp

type IfExpression() =
   interface IConditionalOperator with
      member this.GetName color =
          if color = Color.White then "White"
          elif color = Color.Silver then "Silver"
          elif color = Color.Gray then "Gray"
          elif color = Color.Black then "Black"
          elif color = Color.Red then "Red"
          elif color = Color.Maroon then "Maroon"
          elif color = Color.Yellow then "Yellow"
          elif color = Color.Olive then "Olive"
          elif color = Color.Lime then "Lime"
          elif color = Color.Green then "Green"
          elif color = Color.Aqua then "Aqua"
          elif color = Color.Teal then "Teal"
          elif color = Color.Blue then "Blue"
          elif color = Color.Navy then "Navy"
          elif color = Color.Fuchsia then "Fuchsia"
          elif color = Color.Purple then "Purple"
          else "None"
