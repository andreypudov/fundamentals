// <copyright file="OutputParameter.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ErrorHandling
{
    /// <summary>
    /// Represents an error handling using an output parameter.
    /// </summary>
    public class OutputParameter : IErrorHandler
    {
        private const int ExitFailure = -1;

        /// <inheritdoc />
        public void HandleError()
        {
            DummyMethod(out int errorCode);
        }

        private static void DummyMethod(out int errorCode)
        {
            errorCode = ExitFailure;
        }
    }
}