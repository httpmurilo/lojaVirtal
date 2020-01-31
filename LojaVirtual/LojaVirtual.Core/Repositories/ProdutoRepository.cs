using LojaVirtual.Core.Data;
using LojaVirtual.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Core.Repositories;



namespace LojaVirtual.Core.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {

        
        public ProdutoRepository(LojaContexto contexto) : base(contexto)
        {
            
        }
        public IList<Produto> GetProdutos()
        {
            
           return dbSet.ToList();
            
        }

        public void SaveProdutos(List<Livros> livros)
        {
            foreach (var livro in livros)
            {//retorna os mesmos elementos com os mesmos codigos que estao sendo importados
             //se nao encontrar executa o codigo
             if (!dbSet.Where(p => p.Codigo == livro.Codigo).Any())
                {
              dbSet.Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }
               

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
