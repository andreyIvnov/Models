using Models;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace DAL
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        public DataContext() : base("DbCars") { _ = SqlProviderServices.Instance; }
    }
}