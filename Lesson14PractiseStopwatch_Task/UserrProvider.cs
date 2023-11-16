using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Lesson14PractiseStopwatch_Task.UnitTest")]

namespace Lesson14PractiseStopwatch_Task
{
    internal class UserrProvider
    {
        protected readonly string connection;

        public string Connection { get { return connection; } }

        public UserrProvider()
        {

        }

        public UserrProvider(string connection)
        {
            this.connection = connection;
        }

        public async Task SearchUserr(int age)
        {
            Console.WriteLine($"This age is {age}");
            GetUserrAge("Test");
            await Task.Delay(100);
        }

        private int GetUserrAge(string name)
        {
            return 1;
        }
    }
}