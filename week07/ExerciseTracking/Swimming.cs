using System;

namespace FitnessTrackerApp
{
    class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int length, int laps)
            : base(date, length)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            double km = _laps * 50.0 / 1000.0;
            return km * 0.62;
        }

        public override double GetSpeed()
        {
            double hours = Length / 60.0;
            return GetDistance() / hours;
        }

        public override double GetPace()
        {
            return Length / GetDistance();
        }
    }
}