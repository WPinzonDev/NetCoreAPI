namespace PDAPI.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public int Calificacion { get; set; }
        public int Existencias { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
    }
}
