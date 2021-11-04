using Microsoft.EntityFrameworkCore;
using SignApi.Entities;

namespace SignApi.DAL
{
    public class SignContext : DbContext
    {
        public SignContext(DbContextOptions<SignContext> options) : base(options)
        {
        }
        public DbSet<Sign> Signs { get; set; }
    }
}
