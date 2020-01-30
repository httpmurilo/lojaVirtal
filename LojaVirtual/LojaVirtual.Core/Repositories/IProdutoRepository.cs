using LojaVirtual.Core.Models;
using System.Collections.Generic;

namespace LojaVirtual.Core.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<ProdutoRepository.Livros> livros);
        IList<Produto> GetProdutos();
    }
}