using System;
using System.Collections.Generic;
using TelemetryRecorder.Common;
using Android.Content;

namespace TelemetryRecorder.Droid
{
    public class TelemetryRecorder : ITelemetryRecorder
    {
        Edu.Self.Telemetry_recorder.TelemetryRecorder _Recorder;

        public TelemetryRecorder(Context appContext)
        {
            _Recorder = new Edu.Self.Telemetry_recorder.TelemetryRecorder(appContext);
        }

        public bool IsStarted => _Recorder.IsStarted;

        public List<Trip> Trips => throw new NotImplementedException();

        public string GetRegistration(string userHostAppId)
        {
            return _Recorder.GetRegistration(userHostAppId);
        }

        public string Register(string userHostAppId)
        {
            return _Recorder.Register(userHostAppId);
        }

        public void Start()
        {
                _Recorder.Start();
        }

        public void Stop()
        {
                _Recorder.Stop();
        }
    }
}
