using System.Collections.Generic;
using HalconDotNet;
using System;

namespace HalconImageAcquisition
{
    public interface IMainView
    {
        List< HWindowControl > HWindowControls { get; }

        event EventHandler InitializeHalconEvent;
        event EventHandler TriggerCameraEvent;
    }
}
