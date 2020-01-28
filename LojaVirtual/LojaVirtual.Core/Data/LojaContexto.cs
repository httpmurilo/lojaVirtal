using LojaVirtual.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Core.Data {
    public class LojaContexto : DbContext {
        public LojaContexto (DbContextOptions options) : base (options) { }
        protected override void OnModelCreating (ModelBuilder builder) {
            base.OnModelCreating (builder);
            builder.Entity<Produto> ().HasKey (l => l.Id);
            builder.Entity<Pedido> ().HasMany (t => t.Itens).WithOne (t => t.Pedido);
            builder.Entity<Pedido> ().HasOne (t => t.Cadastro).WithOne (t => t.Pedido).IsRequired();
            builder.Entity<Pedido> ().HasKey (l => l.Id);
            builder.Entity<ItemPedido> ().HasKey (l => l.Id);
            builder.Entity<ItemPedido> ().HasOne (t => t.Pedido);
            builder.Entity<ItemPedido> ().HasKey (t => t.Produto);
            builder.Entity<Cadastro> ().HasKey (t => t.Id);
            builder.Entity<Cadastro> ().HasKey (t => t.Pedido);

        }
    }
}