using Microsoft.EntityFrameworkCore;
using RedbullAPI.Models;

namespace RedbullAPI.Contexts
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            : base(options) { }

        public DbSet<Redbull> Redbulls { get; set; } = null!;
    }
}

// DEPEDENCY INJECTION - LES OPP OM DETTE