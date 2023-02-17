using Microsoft.EntityFrameworkCore;
using PruebaTecnicaBSortf.Entities;
using PruebaTecnicaBSortf.Models;
using PruebaTecnicaBSortf.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaBSortf.Implement
{
    public class ProductoImpl : IProductoRepository
    {
        private readonly PruebaTecnicaBsorftContext _contex;
        public ProductoImpl(PruebaTecnicaBsorftContext context)
        {
            _contex = context;
        }

        public async Task ActualizarProduco(Producto producto)
        {
            _contex.Entry(producto).State = EntityState.Modified;
            await _contex.SaveChangesAsync();
            
        }

        public async Task CrearProducto(Producto producto)
        {
            await _contex.Productos.AddAsync(producto);
            await _contex.SaveChangesAsync();

        }

        public async Task EliminarProducto(Producto producto)
        {
            await _contex.Productos.FindAsync(producto);
            await _contex.SaveChangesAsync();
        }

        public async Task<IEnumerable<Producto>> GetAllProduct()
        {
            return await _contex.Productos.ToListAsync();
        }

        

        public async Task<Producto> GetProductById(int id)
        {
            return await _contex.Productos.FindAsync(id);
        }

    }


}
