using Core.DB;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Infrastructure.DB
{
    public partial class DbMgr : IDbMgr
    {
        public static DbContext Context { get; set; }
        public static readonly UpdateOptions Options = new UpdateOptions() { IsUpsert = true };

        #region Construct / Destruct
        public DbMgr() : this(context:Context)
        {
        }

        public DbMgr(DbContext context)
        {
            Context = context;
        }

        public DbMgr(IConfiguration config)
        {
            Context = new DbContext(config["ConnectionStrings:Main"]);
        }
        #endregion

        #region Methods
        public BsonDocument Filter() { return new BsonDocument(); }
        
        public BsonDocument Filter(string filterById) { return new BsonDocument("_id", filterById); }

        public BsonDocument Filter(string key, BsonValue value) { return new BsonDocument(key, value); }
        #endregion
    }
}