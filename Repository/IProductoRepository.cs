using Microsoft.EntityFrameworkCore.Update.Internal;
using PruebaTecnicaBSortf.Entities;
using PruebaTecnicaBSortf.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnicaBSortf.Repository
{
    public interface IProductoRepository
    {

        public Task<IEnumerable<Producto>> GetAllProduct();
        public Task<Producto> GetProductById(int id);
        public Task CrearProducto(Producto producto);
        public Task ActualizarProduco(Producto producto);

        public Task EliminarProducto(Producto producto); 
       

    }
}
