// <copyright file="Exception.cs" company="Andrey Pudov">
//     Copyright (c) Andrey Pudov. All Rights Reserved. Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.
// </copyright>

namespace Fundamentals.Lang.CSharp.ErrorHandling
{
    /// <summary>
    /// Represents an error handling using exception.
    /// </summary>
    public class Exception : IErrorHandler
    {
        /// <inheritdoc />
        public void HandleError()
        {
            try
            {
                DummyMethod();
            }
            catch (System.Exception)
            {
                /* intentionally blank page */
            }
        }

        private static void DummyMethod()
        {
            throw new System.Exception();
        }
    }
}
