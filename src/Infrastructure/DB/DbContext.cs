using Core;
using Infrastructure.DB_Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.DB
{
    public class DbContextTBGP : DbContext
    {
        #region DbSets
        public DbSet<Status> Statuses { get; set; }
        #endregion

        #region Properties
        public static string Server { get; set; }
        #endregion

        #region Construct / Destruct
        public DbContextTBGP() { }

        public DbContextTBGP(string server)
        {
            Server = server;
        }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseMySql(Server);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ETSConverter = new EnumToStringConverter<Enums.StatusState>();
            modelBuilder.Entity<Status>().Property(s => s.State).HasConversion(ETSConverter);
        }
        #endregion
    }
}