using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Dsw2026Ej8.problema_4
{
    internal class Problema4
    {
        private int? _nota1;
        private int? _nota2;
        private int? _nota3;
        public Problema4(int? nota1,int? nota2, int? nota3) 
        { 
           _nota1 = nota1;
           _nota2 = nota2;
           _nota3 = nota3;
        }
        public int? GetNota1 ()
        {
            return _nota1;
        }
        public int? Setnota1(int? nota1)
        {
            return _nota1 = nota1;
        }

        public int? GetNota2()
        {
            return _nota2;
        }
        public int? Setnota2(int? nota2)
        {
            return _nota2 = nota2;
        }
        public int? GetNota3()
        {
            return _nota3;
        }
        public int? Setnota3(int? nota3)
        {
            return _nota3 = nota3;
        }

        public double CalcularPromedio(int? nota1, int? nota2, int? nota3) 
        {
            if (nota1 < 0 || nota1 > 10) nota1 = null;
            if (nota2 < 0 || nota2 > 10) nota2 = null;
            if (nota3 < 0 || nota3 > 10) nota3 = null;

            if (nota2 == null && nota3 == null && nota1 != null)
            {
                return (double)nota1;
            }

            if (nota1 == null && nota3 == null && nota2 != null)
            {
                return (double)nota2;
            }

            if (nota1 == null && nota2 == null && nota3 != null)
            {
                return (double)nota3;
            }

            if (nota1 == null && nota2 != null && nota3 != null)
            {
                return (double)(nota2 + nota3) / 2;
            }

            if (nota2 == null && nota1 != null && nota3 != null)
            {
                return (double)(nota1 + nota3) / 2;
            }

            if (nota3 == null && nota1 != null && nota2 != null)
            {
                return (double)(nota1 + nota2) / 2;
            }

            if (nota3 != null && nota1 != null && nota2 != null)
            {
                return (double)(nota1 + nota2 + nota3) / 3;
            }

            return 0;
        }
    }
}
