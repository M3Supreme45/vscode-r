﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Microsoft.R.Platform.Windows.Registry {
    public interface IRegistry {
        /// <summary>
        /// Root of HLKM application hive for admin-level settings.
        /// </summary>
        string LocalMachineHive { get; }

        IRegistryKey OpenBaseKey(Win32.RegistryHive hive, Win32.RegistryView view);
    }
}
