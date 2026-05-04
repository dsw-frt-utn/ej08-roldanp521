using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_3
{
    internal class Problema3
    {
        public string CompararCopias (int originalValue, Product product)
        {
            int copiaValue = originalValue;
            copiaValue++;
            Product producto = product;
            producto.Setdescription("queso");
            return $"{originalValue}-{copiaValue}-{producto.Getdescription()}";
        }
    }
}
