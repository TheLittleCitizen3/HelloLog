using Microsoft.Extensions.Configuration;
using Serilog;
using System;

namespace HelloLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
            RunLog runLog = new RunLog();
            for (int i = 0; i < 5; i++)
            {
                runLog.RunLogic();
            }

        }
    }
}
