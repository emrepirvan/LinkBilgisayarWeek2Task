using Microsoft.EntityFrameworkCore;

namespace EFCoreLink.API.Models
{
    public class EFCoreLinkDBContext : DbContext
    {
        public EFCoreLinkDBContext(DbContextOptions<EFCoreLinkDBContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

    }
}
