// Build: 2fc2949fe4cfd140f40a67f1a9733b09
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
