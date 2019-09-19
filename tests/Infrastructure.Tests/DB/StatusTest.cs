//using System;
using Infrastructure.DB;
using Infrastructure.DB_Model;
//using Microsoft.Extensions.Configuration;
using Xunit;

namespace TBGP.Tests.Infrastructure
{
    public class StatusTest
    {
        //public IConfiguration Config { get; set; }
        public DbMgr DB { get; set; }
        
        public StatusTest()
        {
            //Config = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //Config = config;
            DB = new DbMgr("mongodb://localhost:27017/TBGP_UnitTest/?connectTimeoutMS=3000&socketTimeoutMS=3000");
        }
        
        [Fact]
        [Trait("NeedsDatabase", "Yes")]
        public void RoughTest1()
        {
            var SUT = DB.GetStatus();
            if (SUT == null) { SUT = new Status(); }
            DB.SaveStatus(SUT);
        }
    }
}
