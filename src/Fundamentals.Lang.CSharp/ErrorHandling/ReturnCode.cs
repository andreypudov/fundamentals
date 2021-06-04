// <copyright file="ReturnCode.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ErrorHandling
{
    /// <summary>
    /// Represents an error handling using error code.
    /// </summary>
    public class ReturnCode : IErrorHandler
    {
        private const int ExitFailure = -1;

        /// <inheritdoc />
        public void HandleError()
        {
            int errorCode = DummyMethod();
        }

        private static int DummyMethod()
        {
            return ExitFailure;
        }
    }
}