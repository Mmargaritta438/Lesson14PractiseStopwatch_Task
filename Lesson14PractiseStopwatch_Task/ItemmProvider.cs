using System.Threading.Tasks;

namespace Lesson14PractiseStopwatch_Task
{
    internal interface ItemmProvider
    {
        Task<string> GetAsync();
    }

    internal class ItemmProvader : ItemmProvider
    {
        public async Task<string> GetAsync()
        {
            await Task.Delay(5000);
            return string.Empty;
        }
    }
}