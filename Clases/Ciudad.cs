using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject3.Clases
{
    internal class Ciudad
    {
        private string _nombre;
        private int _codPostal;

        public string Nombre { get; set; }
        public int CodigoPostal { get; set; }

        public Ciudad(string nombre, int cp)
        {
            this.Nombre = nombre;
            this.CodigoPostal = cp;
        }


    }
}