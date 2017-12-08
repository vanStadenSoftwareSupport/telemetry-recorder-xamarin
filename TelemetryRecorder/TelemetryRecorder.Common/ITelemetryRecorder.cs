using System;
using System.Collections.Generic;

namespace TelemetryRecorder.Common
{
    public interface ITelemetryRecorder
    {
        string GetRegistration(string userHostAppId);
        string Register(string userHostAppId);
        bool IsStarted { get; }
        void Start();
        void Stop();
        List<Trip> Trips{get;}
    }
}
