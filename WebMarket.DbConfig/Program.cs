using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebMarket.EF;

namespace WebMarket.DbConfig
{
    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public static IConfigurationRoot Configuration { get; set; }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);

            Configuration = builder.Build();

            ConnectionStringGetter.ConnectionString = Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
    }
}
