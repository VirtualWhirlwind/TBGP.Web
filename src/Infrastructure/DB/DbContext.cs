using Infrastructure.DB_Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Infrastructure.DB
{
    public class DbContext
    {
        #region DbSets
        public IMongoCollection<Status> Statuses { get; set; }
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

            // Set up MongoDB conventions
            var pack = new ConventionPack
            {
                new EnumRepresentationConvention(BsonType.String)
                // Dictionary?
            };

            ConventionRegistry.Register("EnumStringConvention", pack, t => true);

            // Initialize DbSet Collections Here
            Statuses = DB.GetCollection<Status>(typeof(Status).Name);
        }
        #endregion
    }
}