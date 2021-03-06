// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_ShmOpen", SetLastError = true)]
        internal static extern SafeFileHandle ShmOpen(string name, OpenFlags flags, int mode);

        [DllImport(Libraries.SystemNative, EntryPoint = "SystemNative_ShmUnlink", SetLastError = true)]
        internal static extern int ShmUnlink(string name);
    }
}
