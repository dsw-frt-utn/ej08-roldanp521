using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_6
{
    internal static class extensions
    {
        public static string ToProductCode(this string code) 
        { 
            if (code == null)
            {
                return $"SIN-CODIGO";
            }
            return code.Trim().ToUpper().Replace(" ", "-");
        }
    }

    
}
