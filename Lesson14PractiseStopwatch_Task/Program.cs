//using System;
//using System.Diagnostics;
//using System.Threading.Tasks;
//using Lesson14PractiseStopwatch_Task;

//internal class Program
//{
//private static async Task Main(string[] args)
//{
//var sw = new Stopwatch();
//var itemmProvider = new ItemmProvader();
//sw.Start();
//await itemmProvider.GetAsync();
//Console.WriteLine(sw.IsRunning);

//.Stop();
//Console.WriteLine(sw.IsRunning);
//var timeTaken = sw.ElapsedMilliseconds;
//Console.WriteLine($"Time taken in MS: {timeTaken}");

//var userrProvider = new UserrProvider();
//        sw.Restart();
////sw.Reset(); 
////sw.Start();
//        await userrProvider.SearchUserr(12);
//        sw.Stop();
//        Console.WriteLine($"Time taken by user provader: {sw.ElapsedMilliseconds}");
//        var rand = new Random();
//        var numbers = new int[10000000];
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = rand.Next(-10000, 10000);
//        }
//
//        for (int threadCount = 1; threadCount <= 8; threadCount *= 2)
//        {
//            var sw = Stopwatch.StartNew();
//            long totalSum = 0;
//
//            var tasks = new Task[threadCount];
//            for (int i = 0; i < threadCount; i++)
//            {
//                int start = i * numbers.Length / threadCount;
//                int end = (i + 1) * numbers.Length / threadCount;
//                tasks[i] = Task.Run(() =>
//                {
//                    long sum = 0;
//                    for (int j = start; j < end; j++)
//                    {
//                        sum += numbers[j];
//                    }
//                return sum;
//                return sum;
//                }).ContinueWith(t => totalSum += t.Result);
//            }
//
//            Task.WaitAll(tasks);
//            sw.Stop();
//
//            Console.WriteLine($"Threads: {threadCount}, Time: {sw.ElapsedMilliseconds} ms, Sum: {totalSum}");
//        }
//    }
//}
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using Lesson14PractiseStopwatch_Task.EfficientStopwatch;

//BenchmarkRunner.Run<>TimeBenchmarks();

//return;

//var stopwatch = Stopwatch.StartNew();

var startTime = Stopwatch.GetTimestamp();

await Task.Delay(1000);
//var endTime = Stopwatch.GetTimestamp();

var diff = Stopwatch.GetElapsedTime(startTime);//(startTime, endTime);

Console.WriteLine(diff);
