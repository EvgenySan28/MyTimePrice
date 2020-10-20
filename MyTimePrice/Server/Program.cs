using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Server.HttpSys;

namespace MyTimePrice.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    //    public static IHostBuilder CreateHostBuilder(string[] args) =>
    //Host.CreateDefaultBuilder(args)
    //    .ConfigureWebHostDefaults(webBuilder =>
    //    {
    //        webBuilder.UseHttpSys(options =>
    //        {
    //            options.AllowSynchronousIO = false;
    //            options.Authentication.Schemes = AuthenticationSchemes.None;
    //            options.Authentication.AllowAnonymous = true;
    //            options.MaxConnections = null;
    //            options.MaxRequestBodySize = 30000000;
    //            options.UrlPrefixes.Add("http://172.14.5.5:5000");
    //            options.UrlPrefixes.Add("https://172.14.5.5:5001");
    //        });
    //        webBuilder.UseStartup<Startup>();
    //    });
    }
}
