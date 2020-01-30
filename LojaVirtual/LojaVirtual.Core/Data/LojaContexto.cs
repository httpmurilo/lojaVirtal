using LojaVirtual.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Core.Data {
    public class LojaContexto : DbContext {
        public LojaContexto (DbContextOptions options) : base (options) { }
        protected override void OnModelCreating (ModelBuilder builder) {
            base.OnModelCreating (builder);

            builder.Entity<Produto>().HasKey(t => t.Id);

            builder.Entity<Pedido>().HasKey(t => t.Id);
            builder.Entity<Pedido>().HasMany(t => t.Itens).WithOne(t => t.Pedido);
            builder.Entity<Pedido>().HasOne(t => t.Cadastro).WithOne(t => t.Pedido).HasForeignKey<Cadastro>(t => t.Id).IsRequired();

            builder.Entity<ItemPedido>().HasKey(t => t.Id);
            builder.Entity<ItemPedido>().HasOne(t => t.Pedido);
            builder.Entity<ItemPedido>().HasOne(t => t.Produto);

            builder.Entity<Cadastro>().HasKey(t => t.Id);
            builder.Entity<Cadastro>().HasOne(t => t.Pedido);

        }
    }
}