using Server.Repository.Service.Employee;
using SharedLibrary.Models.Employee;

namespace Server.Repository
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) :base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MstUser>().HasData(
                new MstUser { 
                    Id = 1,
                    UserCode = "manager",
                    Password = "kuch bhi likh lo per login nahi ker pao gay",
                    UserType = 1,
                    Employee = null,
                    Unit = null,
                    Company = null,
                    CreatedBy = "Auto",
                    UpdatedBy = "Auto",
                    cAppStamp = "Auto",
                    uAppStamp = "Auto",
                });
        }

        #region All Tables
        public DbSet<MstUser> MstUsers { get; set; }
        public DbSet<MstEmployee> MstEmployees { get; set;}


        #endregion

    }
}
