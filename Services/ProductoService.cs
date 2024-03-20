using Microsoft.EntityFrameworkCore;
using PDAPI.Models;

namespace PDAPI.Services
{
    public class ProductoService
    {
        private readonly AppDbContext _context;

        public ProductoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Producto>> ObtenerProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto> ObtenerProducto(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<Producto> AgregarProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task<bool> ActualizarProducto(int id, Producto producto)
        {
            producto.Id = id;
            if (id != producto.Id)
            {
                return false;
            }

            _context.Entry(producto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async Task<bool> EliminarProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return false;
            }

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return true;
        }

        public bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }
    }
}
