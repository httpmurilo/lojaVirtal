using LojaVirtual.Core.Data;
using LojaVirtual.Core.Models;

namespace LojaVirtual.Core.Repositories
{

    public interface ICadastroRepository
    {

    }

    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(LojaContexto contexto) : base(contexto)
        {
        }
    }
}