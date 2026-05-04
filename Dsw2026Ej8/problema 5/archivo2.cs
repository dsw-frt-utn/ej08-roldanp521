using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_5
{
    partial class WholesaleSale : Sale
    {
        private decimal _importecondescuento;
        public WholesaleSale(decimal importe) : base(importe)
        {
            
        }
        public override decimal CalculateTotal()
        {
            return _importe * (1- 0.10m) ;
        }
    }
}
