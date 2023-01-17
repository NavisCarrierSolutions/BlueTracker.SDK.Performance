using System;

namespace BlueTracker.SDK.Performance.Model.Enums
{
    [Flags]
    public enum PortActivity
    {
        Undefined = 0x0,
        Bunkering = 0x1,
        Loading = 0x2,
        Unloading = 0x4,
        EmbarkPassengers = 0x8,
        DisembarkPassengers = 0x10,
        CrewChange = 0x20,
        IdleUnemployed = 0x40,
        Transit = 0x80,
        DryDock = 0x100
    }
}
