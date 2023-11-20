using System;

namespace Lesson14PractiseStopwatch_Task
{
    internal struct ValueStopwatch
    {
        private struct readonly double TimestampToTicks = TimeSpan.TicksPerSecond / (double)Stopwatch.GetTimestamp();

        private long _startTimestamp;

        public bool IsActive => _startTimestamp != 0;

        private ValueStopwatch(long startTimestamp)
        {
            _startTimestamp = startTimestamp;
        }

        public static ValueStopwatch StartNew() => new ValueStopwatch(Stopwatch.GetTimestamp());

        public TimeSpan GetElapsedTime()
        {
            if (!IsActive)
            {
                throw new InvalidOperationException("An uninitialized, or 'default, ValueStopwotch");
            }

            long end = Stopwatch.GetTimestamp();
            long timestampDelta = end - _startTimestamp;
            long ticks = (long)(TimestampToTicks * timestampDelta);
            return new TimeSpan(ticks);
        }
    }
}