using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    internal class Pentagono : IFigura
    {
        public string Tipo { get; set; }
        public string Texto { get; set; }
        public string Caracteristicas { get; set; }

        public int CalcularArea(string caracteristicas)
        {
            string preRadio = caracteristicas.Split(';')[0];
            int radio = Int32.Parse(preRadio.Split('=')[1]);
            double area = radio * radio * 3.14;
            return (int)area;
        }

        public int CalcularEspacioDisponible(string caracteristicas)
        {
            string preRadio = caracteristicas.Split(';')[0];
            int radio = Int32.Parse(preRadio.Split('=')[1]);
            int espacio = radio * 2;
            return espacio;
        }
    }
}
