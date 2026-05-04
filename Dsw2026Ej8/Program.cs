using Dsw2026Ej8.Domain;
using Dsw2026Ej8.problema_2;
using Dsw2026Ej8.problema_3;
using Dsw2026Ej8.problema_4;
using Dsw2026Ej8.problema_5;
using Dsw2026Ej8.problema_6;
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

            Product product2 = new Product("anana", 15);
            Problema3 pbrl3 = new Problema3();
            string modificacion = pbrl3.CompararCopias(15, product2);
            Console.WriteLine("///PRODUCTO3///");
            Console.WriteLine(modificacion);

            Problema4 prom = new Problema4 (10,5,5);
            double promedio = prom.CalcularPromedio(10,5,5);
            Console.WriteLine("///PROMEDIO///");
            Console.WriteLine(promedio);

            
            Sale ventaMayorista = new WholesaleSale(1000m);
            Sale ventaMinorista = new RetailSale(1000m);
            Problema5 prob5 = new Problema5();
            decimal totalMinorista = prob5.ObtenerImporteFinal(ventaMinorista);
            decimal totalMayorista = prob5.ObtenerImporteFinal(ventaMayorista);
            Console.WriteLine($"Total Venta Minorista: ${totalMinorista}");
            Console.WriteLine($"Total Venta Mayorista: ${totalMayorista}");

            Problema6 prob6 = new Problema6();
            string resultado = prob6.NormalizarCodigoProducto(" ab 123 x ");
            Console.WriteLine($"Codigo: {resultado}");
        }
    }
}
