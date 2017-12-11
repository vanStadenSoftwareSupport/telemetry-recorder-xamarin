using System;
namespace TelemetryRecorder.Common
{
    public class Trip
    {
        public DateTimeOffset StartDate
        {
            get;
        }


        public DateTimeOffset EndDate
        {
            get;
            set;
        }

        public String FromSuburb
        {
            get;
            set;
        }

        public String ToSuburb
        {
            get;
            set;
        }

        public int DistanceInKilometers
        {
            get;
            set;
        }

        public int DurationInMinutes
        {
            get;
            set;
        }
    }
}
