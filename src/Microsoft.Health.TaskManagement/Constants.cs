﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.JobManagement
{
    public static class Constants
    {
        public const int DefaultPollingFrequencyInSeconds = 10;

        public const short DefaultMaxRunningJobCount = 1;

        public const short DefaultMaxRetryCount = 3;

        public const int DefaultJobHeartbeatTimeoutThresholdInSeconds = 120;

        public const int DefaultJobHeartbeatIntervalInSeconds = 10;
    }
}
