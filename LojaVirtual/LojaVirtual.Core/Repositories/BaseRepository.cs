using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Core.Data;
using LojaVirtual.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtual.Core.Repositories
{
    public abstract class BaseRepository<T> where T:BaseModel
    {
        
        protected  readonly DbSet<T> dbSet;
        protected readonly LojaContexto contexto;
        //visivel para as classes derivadas
        public BaseRepository(LojaContexto contexto)
        {
            this.contexto = contexto;
           dbSet= contexto.Set<T>();
        }
}
}