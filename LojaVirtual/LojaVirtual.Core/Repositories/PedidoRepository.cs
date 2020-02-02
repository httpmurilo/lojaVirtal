using LojaVirtual.Core.Data;
using LojaVirtual.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LojaVirtual.Core.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor acessor;
        public PedidoRepository(LojaContexto contexto,
            IHttpContextAccessor acessor) : base(contexto)
        {
            this.acessor = acessor;
        }

        public void AddItem(string codigo)
        {
            var produto = contexto
                .Set<Produto>()
                .Where(p => p.Codigo == codigo)
                .SingleOrDefault();

            if (produto == null)
            {
                throw new ArgumentException("Produto n�o encontrado");
            }
            var pedido = GetPedido();
            var itemPedido = contexto.Set<ItemPedido>()
                 .Where(i => i.Produto.Codigo == codigo &&
                 i.Pedido.Id == pedido.Id)
                .SingleOrDefault();
            if (itemPedido == null)
            {
                itemPedido = new ItemPedido(pedido, produto, 1, produto.Preco);
                contexto.Set<ItemPedido>()
                    .Add(itemPedido);
                contexto.SaveChanges();
            }
        }

        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = dbSet
                .Include(p => p.Itens)
                .ThenInclude( i => i.Produto)
                .Where(p => p.Id == pedidoId)
                .SingleOrDefault();
            if (pedido == null)
            {
                pedido = new Pedido();
                dbSet.Add(pedido);
                contexto.SaveChanges();
                SetPedidoId(pedido.Id);
            }
            return pedido;
        }

        private int? GetPedidoId()
        {
            //persiste o id na sessao
            return acessor.HttpContext.Session.GetInt32("pedidoId");

        }
        private void SetPedidoId(int pedidoId)
        {
            acessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }
    }
}