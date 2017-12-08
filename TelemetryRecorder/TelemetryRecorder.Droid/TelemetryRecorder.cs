using System;
using System.Collections.Generic;
using TelemetryRecorder.Common;

namespace TelemetryRecorder.Droid
{
    public class TelemetryRecorder: ITelemetryRecorder 
    {
        public bool IsStarted => throw new NotImplementedException();

        public List<Trip> Trips => throw new NotImplementedException();

        public string GetRegistration(string userHostAppId)
        {
            throw new NotImplementedException();
        }

        public string Register(string userHostAppId)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
