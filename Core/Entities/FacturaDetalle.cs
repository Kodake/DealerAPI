namespace Core.Entities
{
    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
    }
}
