using System.Data.Entity;
using ManageApi.Models;

namespace ManageApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
          base("ManageApiConnectionString")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }

    }
}