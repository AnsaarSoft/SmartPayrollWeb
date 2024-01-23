using SharedLibrary.Models.Employee;

namespace Server.Repository
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) :base(options)
        {
                
        }

        #region All Tables
        public DbSet<MstUser> MstUser { get; set; }

        #endregion

    }
}
