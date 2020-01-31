using LojaVirtual.Core.Data;
using LojaVirtual.Core.Models;

namespace LojaVirtual.Core.Repositories
{
    public interface IItemPedidoRepository
    
    {
        
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(LojaContexto contexto) : base(contexto)
        {
            
        }
    }
}


