using MongoDB.Bson;
using MongoDB.Driver;

namespace Infrastructure.DB
{
    public class DbContext
    {
        #region DbSets
        #endregion

        #region Properties
        public static string Server { get; set; }

        public IMongoClient Client { get; set; }
        public IMongoDatabase DB { get; set; }
        #endregion

        #region Construct / Destruct
        public DbContext() { SetCollections(); }

        public DbContext(string server)
        {
            Server = server;

            SetCollections();
        }
        #endregion

        #region Methods
        public void SetCollections()
        {
            if (Server == null || string.IsNullOrEmpty(Server)) { return; }

            Client = new MongoClient(Server);
            DB = Client.GetDatabase(new MongoUrl(Server).DatabaseName);

            // Initialize DbSet Collections Here
            
        }
        #endregion
    }
}