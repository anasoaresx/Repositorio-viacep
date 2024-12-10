using Microsoft.EntityFrameworkCore;
using Noticiario.Models;

namespace Noticiario.Data
{
    public class NewContext : DbContext
    {
        public NewContext(DbContextOptions<NewContext> options) : base(options) 
        { 
        }

        public DbSet<New>news { get; set; }
    }
}
