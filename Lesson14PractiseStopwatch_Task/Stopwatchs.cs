using System;
using System.Diagnostics;

namespace Lesson14PractiseStopwatch_Task
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial class Stopwatch
    {
        private const long TicksPerMillisecond = 10000;
        private const long TicksPerSecond = TicksPerMillisecond * 1000;

        private long _elapsed;

        private long _startTimeStamp;

        private bool _isRunning;

        public static readonly Frequency = QueryPerfomanceFrequency();

        public static readonly bool IsHighResolution = true;

        private static readonly double s_tickFrequency = (double)TicksPerMillisecond / Frequency();

        public Stopwatch()
        {
            Reset();
        }

        public void Start()
        {
            if (!_isRunning)
            {
                _startTimeStamp = GetTimestamp();
                _isRunning = true;
            }
        }

        public static Stopwatch StarNew()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            return s;
        }

        public void Stop()
        {
            if (_isRunning)
            {
                long endTimeStamp = GetTimestamp();
                long elapsedThisPeriod = GetTimestamp - _startTimeStamp();
                _elapsed += elapsedThisPeriod;
                _isRunning = false;
                _startTimeStamp = endTimeStamp;
            }
        }

        public long ElapsedTicks
        {
            get { return GetRawElapsedTicks(); }
        }

        public static long GetTimestamp()
        {
            Debug.Assert(IsHighResolution);
            return QueryPerfomanceCounter();
        }

        /// <summmery>Gets the elapsed time since the <paramref name="startingTimestamp"/> var 
        /// <param name="startingTimestamp">The timestamp marking the beginning of the time period.</param>
        /// <returns>A <see cref="TimeSpan"/> for the elapsed time between the starting and</returns>

        public static TimeSpan GetElapsegTime(long startingTimestamp) =>
            GetElapsegTime(startingTimestamp, GetTimestamp());

        /// <summary>Gets the elapsed time bettwen two timestamps retrieved using <see cref="TimeSpan"/></summary>
        /// <param name="startingTimestamp">The timestamp marking the beginning of the time period.</param>
        /// <param name="edingTimestamp">The timestamp marking the end of the time period.</param>
        /// <returns>A <see cref="TimeSpan"/> for the elapsed time between the starting and</returns>

        public static TimeSpan GetElapsedTime(long startingTimestamp, long endingTimestamp) =>
            new TimeSpan((long)((endingTimestamp - startingTimestamp) * s_tickFrequency));

        private long GetRawElapsedTicks()
        {
            long timeElapsed = _elapsed;

            if (_isRunning)
            {
                long currentTimeStamp = GetTimestamp();
                long elapsedUntilNow = currentTimeStamp - _startTimeStamp();
                timeElapsed += elapsedUntilNow;
            }
            return timeElapsed;
        }
    }
}
