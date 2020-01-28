namespace LojaVirtual.Core.Data
{
    public class DataService
    {
        private readonly LojaContexto contexto ;

        public DataService (LojaContexto contexto)
        {
            this.contexto = contexto;
        }
        public void InicializeDb()
        {
            contexto.Database.EnsureCreated();
            var json = File.ReadllText("livros.json");
            jsonConvert.DeserializeObject<List<Livros>>(json);
            var livros = jsonConvert.DeserializeObject<List<Livros>>(json);

        }

    }
    class Livros
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Preco {get;set;}
    }
}

//instalar o netwonsoft

