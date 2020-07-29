using System;

namespace FarMory
{
    [Flags]
    public enum SunExposure
    {
        Unset = 0,
        FullSun = 1,
        SemiShade = 1 << 4,
        Shaded = 1 << 8
    }
}