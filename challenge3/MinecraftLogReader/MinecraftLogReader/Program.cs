using System;

namespace MinicraftLogReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpoint = Environment.GetEnvironmentVariable("MINECRAFT_ENDPOINT");
            while (true)
            {
                MineStat ms = new MineStat(endpoint, 25565);
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
                Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(ms));
            }
        }
    }
}