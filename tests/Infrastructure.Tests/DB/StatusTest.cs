using Infrastructure.DB;
using Xunit;

namespace TBGP.Infrastructure.Tests
{
    public class StatusTest  : BaseTest
    {
        //public IConfiguration Config { get; set; }
        public DbMgr DB { get; set; }
        
        public StatusTest()
        {
            DB = new DbMgr(Config);
        }
        
        //[Fact]
        [Fact(Skip="DB Testing Only")]
        [Trait("NeedsDatabase", "Yes")]
        public void RoughTest1()
        {
            var SUT = DB.GetStatus();
            SUT.State = Core.Enums.StatusState.Maintenance;
            SUT.State = Core.Enums.StatusState.Offline;
            DB.SaveStatus(SUT);
        }

        // public void IsNotNull()
        // {
        //     var SUT = DB.GetStatus();

        //     Assert.NotNull(SUT);
        // }
    }
}
