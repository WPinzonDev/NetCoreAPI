using Microsoft.EntityFrameworkCore;
using PDAPI.Models;

namespace PDAPI
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
