using System.Collections.Generic;
using HalconDotNet;
using System;

namespace HalconImageAcquisition
{
    public interface IMainView
    {
        List<HWindowControl> HWindowControls { get; set; }

        event EventHandler TriggerCameraEvent;
    }
}
