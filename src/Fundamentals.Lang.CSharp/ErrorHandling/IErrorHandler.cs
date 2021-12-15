// <copyright file="IErrorHandler.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ErrorHandling;

/// <summary>
/// Exposes an operator that provides the conditional execution.
/// </summary>
public interface IErrorHandler
{
    /// <summary>
    /// Handles a simulated error in the execution.
    /// </summary>
    void HandleError();
}
