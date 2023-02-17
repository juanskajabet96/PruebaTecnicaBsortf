using Microsoft.EntityFrameworkCore;
using PruebaTecnicaBSortf.Models;
using PruebaTecnicaBSortf.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnicaBSortf.Implement
{
    public class CategoriaImpl : ICategoriaRepository
    {
        private readonly PruebaTecnicaBsorftContext _contex;
        public CategoriaImpl(  PruebaTecnicaBsorftContext contex)
        {
            _contex = contex;
    }
        public async  Task<IEnumerable<Categorium>> GetAllCategorias()
        {
            return await _contex.Categoria.ToListAsync();
        }

        public async Task<Categorium> GetCategoriaById(int id)
        {
            return await _contex.Categoria.FindAsync(id);
        }
    }
}
