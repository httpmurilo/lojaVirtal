using LojaVirtual.Core.Interfaces;
using LojaVirtual.Core.Models;
using LojaVirtual.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static LojaVirtual.Core.Repositories.ProdutoRepository;

namespace LojaVirtual.Core.Data
{
     class DataService: IDataService
    {
        private readonly LojaContexto contexto;
        private readonly IProdutoRepository produtoRepository;

        public DataService(LojaContexto contexto,
            IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }
        public void InicializaDB()
        {
            contexto.Database.Migrate();
            List<Livros> livros = GetLivros();
            produtoRepository.SaveProdutos(livros);
        }

        private static List<Livros> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livros>>(json);
            return livros;
        }
    }
    
}
