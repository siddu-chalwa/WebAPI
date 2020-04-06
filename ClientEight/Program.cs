using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ClientEight
{
    /// <summary>
    /// class: program: application entry path class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// function: main: entrypoint
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /// <summary>
        /// function: create and configure webhost
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
