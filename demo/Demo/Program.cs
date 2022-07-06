// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
var timer = new Stopwatch();
timer.Start();
var tasks = new List<Task<string>>();
var batchSize = 10000;

var client = new UsersClient();

for (int i = 0; i < batchSize; i++)
{
    tasks.Add(client.GetInfo());
}

await Task.WhenAll(tasks);
timer.Stop();
var timeTaken = timer.Elapsed;
var foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff"); 

Console.WriteLine(foo);
    



