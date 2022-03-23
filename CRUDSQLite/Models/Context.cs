using Microsoft.EntityFrameworkCore;

namespace CRUDSQLite.Models
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
