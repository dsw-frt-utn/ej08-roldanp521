using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_5
{
    partial class RetailSale : Sale
    {
        public RetailSale(decimal importe) : base(importe)
        {
         
        }
        public override decimal CalculateTotal()
        {
            return _importe;
        }
    }
}
