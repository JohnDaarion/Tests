﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace DatabaseConnectionProvider
{
    public class Program
    {
        public static void Main()
        {
            BuildWebHost().Run();
        }

        public static IWebHost BuildWebHost() =>
            WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>()
                .Build();
    }
}
