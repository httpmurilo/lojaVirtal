using LojaVirtual.Core.Data;
using LojaVirtual.Core.Models;
using Microsoft.AspNetCore.Http;

namespace LojaVirtual.Core.Repositories
{
        public interface IPedidoRepository
        {
            
        }

    public class PedidoRepository:BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor acessor;
        public PedidoRepository(LojaContexto contexto, 
            IHttpContextAccessor acessor) : base(contexto)
        {
            this.acessor = acessor;   
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