using Microsoft.EntityFrameworkCore;

namespace ClientEight.Models
{
    /// <summary>
    /// class: inherit DbContext for data aceess uderlying the db
    /// </summary>
    public class DbContextClass : DbContext
    {
        /// <summary>
        /// constructor: for instantiating the dbcontextoptions
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public DbContextClass(DbContextOptions<DbContextClass> dbContextOptions):base(dbContextOptions)
        {

        }
        /// <summary>
        /// database set 
        /// </summary>
        public DbSet<User> entities { get; set; }
        /// <summary>
        /// for initial dataentry
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
