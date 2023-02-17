using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PruebaTecnicaBSortf.Entities;
using PruebaTecnicaBSortf.Models;
using PruebaTecnicaBSortf.Repository;
using System.Threading.Tasks;

namespace PruebaTecnicaBSortf.Controller
{
    [Route("api/[Controller]")]
    public class ProductController : ControllerBase
    {
        private IProductoRepository _productoRepository;

        public ProductController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productoRepository.GetAllProduct();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async  Task<IActionResult> GetProductId(int id )
        {
            var product = await _productoRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

        [HttpPost]
        public async Task<IActionResult> CreateProducto([FromBody] Producto producto )
        {
            if(producto == null)
            {
                return BadRequest();
            }
            await _productoRepository.CrearProducto(producto);
            return CreatedAtAction(nameof(GetProductId), new { id = producto.ProductoId }, producto);
        }

        [HttpPut("{id}")]

        public async Task <IActionResult> UpDateProduct(int idProducto, [FromBody] Producto product) 
        {
            if (product== null || idProducto != product.ProductoId)
            {
                return BadRequest();

            }
            var existingProduct = await _productoRepository.GetProductById(idProducto);
            if(existingProduct == null)
            {
                return NotFound();

            }
            existingProduct.CategoriaId= product.CategoriaId;
            existingProduct.Nombre = product.Nombre;
            existingProduct.Valor= product.Valor;
            await _productoRepository.EliminarProducto(existingProduct);
            return NoContent();


        }
    }
}
