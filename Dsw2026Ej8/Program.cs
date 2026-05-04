using Dsw2026Ej8.Domain;
using Dsw2026Ej8.problema_2;
using System.Dynamic;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper product = new ProductHelper (1000,"manzana",15000);
            string etiqueta       = product.ObtenerEtiquetaProducto (1000, "manzana", 15000);
            Console.WriteLine("///PRODUCTO1///");
            Console.WriteLine(etiqueta);

            Problema2 product1 = new Problema2(1000, "durazno", 10 , 15);
            string total = product1.CrearResumenVenta(1000, "durazno" ,10 , 15);
            Console.WriteLine("///PRODUCTO2///");
            Console.WriteLine(total);
        }
    }
}
