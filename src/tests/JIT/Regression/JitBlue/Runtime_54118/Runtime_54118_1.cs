// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

// Generated by Fuzzlyn v1.2 on 2021-07-22 13:37:14
// Seed: 14815563263006255362
// Reduced from 12.9 KiB to 0.4 KiB in 00:00:17
// Debug: Outputs 1
// Release: Outputs 0

// VN must properly report loop dependence of a PhiMemoryDef
// or the jit will hoist the load of vr7[0] past the store.

public class Runtime_54118
{
    static short[] s_2;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static bool Eval(byte b) => b == 100;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static int Bound() => 2;

    public static int Main()
    {
        byte[] vr7 = new byte[]{0};
        bool vr11 = default(bool);
        bool ok = false;
        int k = Bound();
        for (int vr9 = 0; vr9 < k; vr9++)
        {
            if (vr11)
            {
                s_2[0] = 0;
            }

            vr7[0] = 100;
            byte vr10 = vr7[0];
            ok = Eval(vr10);
        }

        return ok ? 100 : -1;
    }
}
