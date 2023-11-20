using BenchmarkDotNet.Attributes;
using System;
using System.Diagnostics;

namespace Lesson14PractiseStopwatch_Task
{
    //[MemoryDiagnoser(false)]
    public class TimeBenchmarks
    {
        //private static readonly int[] Array { 10, 5, 20};

        //[Benchmark]
        public TimeSpan Old()
        {
            return Stopwatch().Elapsed;
        }

        private object Stopwatch()
        {
            throw new NotImplementedException();
        }

        //[Benchmark]
        public TimeSpan New()
        {
            return Stopwatch.GetElapsedTime(Stopwatch.GetTimestamp());
        }

        [Benchmark]
        public TimeSpan Old_Loop()
        {
            var = Stopwatch.StarNew();
            var length = Array.Length;
            for (var i = 0; i < length; i++)
            {
                DoSomething(i);
            }
            return sw.Elapsed;
        }

        [Benchmark]
        public TimeSpan New_Loop()
        {
            var startTime = Stopwatch.GetTimestamp();
            var length = Array.Length;
            for (var i = 0; i < length; i++)
            {
                DoSomething(i);
            }
            return Stopwatch.GetElapsedTime(startTime);
        }

        private void DoSomething(int val)
        {
            Console.WriteLine(val);
        }
    }
}