using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Dsw2026Ej8.Domain
{
    partial class ProductHelper
    {
        private long _code;
        private string _description;
        private decimal _price;
        public ProductHelper (long code, string description, decimal price)
        {
          _code = code;
          _description = description;
          _price = price;
        }
        public long GetCode ()
        {
            return _code;
        }
        public long SetCode(long code)
        {
            return _code = code;
        }
        public string GetDescription()
        {
            return _description;
        }
        public string SetDescription(string description)
        {
            return _description = description;
        }
        public decimal GetPrice()
        {
            return _price;
        }
        public decimal SetPrice(decimal price)
        {
            return _price = price;
        }

        public const string FormatoEtiqueta = "[{0}] {1} - {2:C2}";
    }
}