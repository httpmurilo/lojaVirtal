using LojaVirtual.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Core.Data
{
    public class LojaContexto:DbContext
    {
        public LojaContexto(DbContextOptions options) : base(options)
        {}
        protected override void OnModelCreating (ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Produto>().HasKey( p => p.Id);
        }
    }
}