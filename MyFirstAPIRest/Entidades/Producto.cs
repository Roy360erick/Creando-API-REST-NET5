namespace MyFirstAPIRest.Entidades
{
    public class Producto
    {
        public int ProductoID { get; set; }

        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
