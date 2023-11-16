using System;
using System.Diagnostics;
using Lesson14PractiseStopwatch_Task;

var sw = new Stopwatch();
var itemmProvider = new ItemmProvader();
sw.Start(); 
await itemmProvider.GetAsync();
Console.WriteLine(sw.IsRunning); 

sw.Stop();
Console.WriteLine(sw.IsRunning);
var timeTaken = sw.ElapsedMilliseconds;
Console.WriteLine($"Time taken in MS: {timeTaken}");    

var userrProvider = new UserrProvider();
sw.Restart();
//sw.Reset(); 
//sw.Start();
await userrProvider.SearchUserr(12);
sw.Stop();
Console.WriteLine(($"Time taken by user provader: {sw.ElapsedMilliseconds}"));