using LojaVirtual.Core.Models;
using System.Collections.Generic;
using static LojaVirtual.Core.Repositories.ProdutoRepository;

namespace LojaVirtual.Core.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livros> livros);
        IList<Produto> GetProdutos();
    }
}