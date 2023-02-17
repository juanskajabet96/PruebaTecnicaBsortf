using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaBSortf.Repository;
using System.Threading.Tasks;

namespace PruebaTecnicaBSortf.Controller
{
    [Route("api/[Controller]")]
    public class DeatlleProductosContoller: ControllerBase
    {
        private IProductoRepository _productoRepository;
        private ICategoriaRepository _categoriRepository;


        public DeatlleProductosContoller(IProductoRepository productoRepository , ICategoriaRepository categoriaRepository )
        {
            _productoRepository= productoRepository;
            _categoriRepository= categoriaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDetailsProductos()
        {
            var products = await _productoRepository.GetAllProduct();
            var caterogias = await _categoriRepository.GetAllCategorias();

            return Ok(products);
        }


    }
}
