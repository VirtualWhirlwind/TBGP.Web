using Core.DB;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.DB
{
    public partial class DbMgr : IDbMgr
    {
        public static DbContextTBGP Context { get; set; }

        #region Construct / Destruct
        public DbMgr() : this(context:Context)
        {
        }

        public DbMgr(DbContextTBGP context)
        {
            Context = context;
        }

        public DbMgr(IConfiguration config)
        {
            Context = new DbContextTBGP(config["ConnectionStrings:Main"]);
        }

        public DbMgr(string connectionString)
        {
            Context = new DbContextTBGP(connectionString);
        }
        #endregion

        #region Methods
        #endregion
    }
}