using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Dsw2026Ej8.problema_5
{
    internal class Sale
    {
        protected decimal _importe;
        public Sale (decimal importe)
        {
            _importe = importe;
        }

        public decimal GetImporte ()
        {
            return _importe;
        }

        public decimal SetImporte(decimal importe)
        {
            return _importe = importe;
        }

        public virtual decimal CalculateTotal ()
        {
           return 0;
        }
    }
}
