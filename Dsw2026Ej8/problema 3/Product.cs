using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.problema_3
{
    internal class Product
    {
        private int _originalValue;
        private string _description;
        public Product(string description, int originalValue )
        {
            _originalValue = originalValue;
            _description = description;
        }
        public int GetoriginalValue() 
        { 
           return _originalValue;
        }
        public int SetoriginalValue(int originalValue)
        {
            return _originalValue = originalValue;
        }
        public string Getdescription()
        {
            return _description;
        }
        public string Setdescription(string description)
        {
            return _description = description;
        }
    }
}
