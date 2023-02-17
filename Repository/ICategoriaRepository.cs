using PruebaTecnicaBSortf.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnicaBSortf.Repository
{
    public interface ICategoriaRepository
    {
        public Task<IEnumerable<Categorium>> GetAllCategorias();
        public Task<Categorium> GetCategoriaById(int id);
    }
}
