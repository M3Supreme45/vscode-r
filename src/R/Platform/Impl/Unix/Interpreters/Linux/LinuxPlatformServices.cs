﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.IO;
using Microsoft.Common.Core;
using Microsoft.Common.Core.Shell;

namespace Microsoft.R.Platform.Interpreters.Mac {
    public class LinuxPlatformServices : IPlatformServices {
        public IntPtr ApplicationWindowHandle => IntPtr.Zero;
        public string ApplicationDataFolder => "/var/lib/RTVS";
        public string ApplicationFolder => Path.GetDirectoryName(typeof(LinuxPlatformServices).Assembly.GetAssemblyPath());
    }
}
