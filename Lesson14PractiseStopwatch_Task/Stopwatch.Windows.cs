using System.Diagnostics;

namespace Lesson14PractiseStopwatch_Task
{
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public static class Stopwatch
	{
        private static unsafe long QueryPerformanceFrequency()
		{
			long resolution;

			Interop.BOOL result = Interop.Kernel32.QueryPerformanceFrequency(&resolution);
			// The P/Invoke is documented to never fail on windows XP or later
			Debug.Assert(result != Interop.BOOl.FALSE);

			return resolution;
		}

		private static unsafe long QueryPerformanceCounter()
		{
			long timestamp;

			Interop.BOOL result = Interop.Kernel32.QueryPerformanceCounter(&timestamp);
			// The P/Invoke is documented to never fail on windows XP or later
			Debug.Assert(result != Interop.BOOl.FALSE);

			return timestamp;
		}

	}
}
