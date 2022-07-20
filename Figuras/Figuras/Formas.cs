﻿namespace Aplicacion
{
    public class Formas
    {
        
        public IFigura GenerarFigura(string figura)
        {
            if(figura == "circulo")
            {
                return new Circulo();
            }

            else if(figura == "rectangulo")
            {
                return new Rectangulo();
            }

            else if(figura == "triangulo")
            {
                return new Triangulo();
            }
            else if (figura == "pentagono")
            {
                return new Pentagono();
            }

            else
            {
                return new FiguraInexistente();
            }
        }

    }
}
