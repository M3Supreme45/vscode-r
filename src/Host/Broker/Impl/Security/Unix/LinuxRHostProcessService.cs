﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using Microsoft.Common.Core.IO;
using Microsoft.Common.Core.OS;
using Microsoft.Extensions.Logging;
using Microsoft.R.Host.Broker.Interpreters;
using Microsoft.R.Host.Broker.RHost;
using Microsoft.R.Host.Broker.Sessions;

namespace Microsoft.R.Host.Broker.Security.Unix {
    internal sealed class LinuxRHostProcessService : RHostProcessService {
        public LinuxRHostProcessService(ILogger<Session> sessionLogger, IFileSystem fs, IProcessServices ps) :
            base(sessionLogger, fs, ps) { }

        protected override string GetRHostBinaryPath() => "/usr/lib/rtvs/Microsoft.R.Host";

        protected override string GetLoadLibraryPath(Interpreter interpreter) {
            var value = Environment.GetEnvironmentVariable("LD_LIBRARY_PATH");
            if (string.IsNullOrEmpty(value)) {
                return interpreter.RInterpreterInfo.BinPath;
            }
            return $"{interpreter.RInterpreterInfo.BinPath}:{value}";
        }
    }
}