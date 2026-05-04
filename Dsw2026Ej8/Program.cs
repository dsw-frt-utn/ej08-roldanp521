using Dsw2026Ej8.Domain;
using System.Dynamic;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper product = new ProductHelper (1000,"manzana",15000);
            string etiqueta       = product.ObtenerEtiquetaProducto (1000, "manzana", 15000);
            Console.WriteLine("///PRODUCTO///");
            Console.WriteLine(etiqueta);
        }
    }
}
