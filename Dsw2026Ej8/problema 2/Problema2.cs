using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8.problema_2
{
    internal class Problema2
    {
        private long _productcode;
        private string _productdescription;
        private int _quantity;
        private decimal _unitprice;
        public Problema2(long productcode, string productdescription, int quantity, decimal unitprice)
        {
            _productcode = productcode;
            _productdescription = productdescription;
            _quantity = quantity;
            _unitprice = unitprice;
        }
        public long GetProductCode()
        {
            return _productcode;
        }
        public long SetProductCode(long productcode)
        {
            return _productcode = productcode;
        }
        public string GetProductDescription()
        {
            return _productdescription;
        }
        public string SetProductDescription(string productdescription)
        {
            return _productdescription = productdescription;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public int SetQuantity(int quantity)
        {
            return _quantity = quantity;
        }
        public decimal GetUnitPrice()
        {
            return _unitprice;
        }
        public decimal SetUnitPrice(decimal unitprice)
        {
            return _unitprice = unitprice;
        }
        public string CrearResumenVenta(long productcode, string productdescription, int quantity, decimal unitprice)
        {
            decimal totalcalculado = 0;

            if (quantity > 0)
            {
                totalcalculado = quantity * unitprice;
            }

            var producto = new
            {
                code = productcode,
                description = productdescription,
                Quantity = quantity,
                Total = totalcalculado,
            };

            return $"{producto.code}-{producto.description}-{producto.Total}";
        }
    }
}





            


        
    

