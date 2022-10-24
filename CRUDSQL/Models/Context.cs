using Microsoft.EntityFrameworkCore;

namespace CRUDSQL.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
}
