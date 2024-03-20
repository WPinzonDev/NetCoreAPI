using Microsoft.AspNetCore.Mvc;
using PDAPI.Models;
using PDAPI.Services;

namespace MiProyectoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoService _productoService;

        public ProductosController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> ObtenerProductos()
        {
            return await _productoService.ObtenerProductos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> ObtenerProducto(int id)
        {
            var producto = await _productoService.ObtenerProducto(id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> AgregarProducto(Producto producto)
        {
            var nuevoProducto = await _productoService.AgregarProducto(producto);
            return CreatedAtAction(nameof(ObtenerProducto), new { id = nuevoProducto.Id }, nuevoProducto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarProducto(int id, Producto producto)
        {
            var result = await _productoService.ActualizarProducto(id, producto);
            return result ? (IActionResult)NoContent() : BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarProducto(int id)
        {
            var result = await _productoService.EliminarProducto(id);
            return result ? (IActionResult)NoContent() : NotFound();
        }
    }
}
