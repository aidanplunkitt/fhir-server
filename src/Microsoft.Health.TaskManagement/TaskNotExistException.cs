﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using EnsureThat;

namespace Microsoft.Health.TaskManagement
{
    public class TaskNotExistException : Exception
    {
        public TaskNotExistException(string message)
            : base(message)
        {
            EnsureArg.IsNotNull(message, nameof(message));
        }

        public TaskNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {
            EnsureArg.IsNotNull(message, nameof(message));
            EnsureArg.IsNotNull(innerException, nameof(innerException));
        }
    }
}
