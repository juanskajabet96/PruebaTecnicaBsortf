using PruebaTecnicaBSortf.Models;

namespace PruebaTecnicaBSortf.Entities
{
    public class ProductoRequest
    {
        public int productoId { get; set; }
        public int categoriaId { get; set; }
        public string nombre { get; set; }
        public int valor { get; set; }
        public CategoriaRequest categoria { get; set; }
    }
}
