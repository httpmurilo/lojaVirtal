using LojaVirtual.Core.Data;
using LojaVirtual.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Core.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly LojaContexto contexto;

        public ProdutoRepository(LojaContexto contexto)
        {
            this.contexto = contexto;
        }

        public IList<Produto> GetProdutos()
        {
            
           return contexto.Set<Produto>().ToList();
            
        }

        public void SaveProdutos(List<Livros> livros)
        {
            foreach (var livro in livros)
            {
                contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));


            }
            contexto.SaveChanges();
        }
        public class Livros
        {
            public string Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }

    }
}
