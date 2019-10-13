using System.IO;
using Microsoft.Extensions.Configuration;

namespace TBGP.Infrastructure.Tests
{
    public class BaseTest
    {
        public IConfigurationRoot Config { get; set; }
        public BaseTest()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .AddEnvironmentVariables(); 
 
            Config = builder.Build();
        }
    }
}