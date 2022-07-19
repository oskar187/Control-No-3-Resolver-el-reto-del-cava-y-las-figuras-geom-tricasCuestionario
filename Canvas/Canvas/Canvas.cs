namespace Libreria
{
    public class Canvas
    {
        public int alto;
        public int ancho;
        public int fuente;
        public double tamPuntoPixel = 0.5;

        public string procesar(int[] areas, string[] tipos, string[] textos, int[] espaciosTextos)
        {
            int areaTotal = CalcularArea(areas);
            bool validarCanvas = ValidarArea(areaTotal);

            string respuesta = "";

            if (validarCanvas)
            {
                string[] figurasIncorrectas = ListarFigurasDiferentes(areas, tipos, textos, espaciosTextos);

                if(figurasIncorrectas.Length > 0) 
                {
                    respuesta = "No se puede!, el texto de una de las figuras no caben en el espacio asignado, " + figurasIncorrectas[0];
                    for (int i = 1; i < figurasIncorrectas.Length; i++)
                    {
                        if(i == (figurasIncorrectas.Length - 1))
                        {
                            respuesta = respuesta + " , " + figurasIncorrectas[i];
                        }
                        else
                        {
                            respuesta = respuesta + ", " + figurasIncorrectas[i];
                        }
                    }
                }
                else
                {
                    respuesta = "Las figuras ingresaron correctamente con sus respectivos textos en el Canvas.!!";

                }
            }
            else
            {
                respuesta = "No se puede!, La suma del área de las figuras(" + areaTotal + ") es mayor que el área del canvas(" + (ancho * alto) + ")";
            }

            return respuesta;
        }

        public int CalcularArea(int[] areas)
        {
            int areaTotal = 0;

            for(int i = 0; i< areas.Length; i++)
            {
                areaTotal = areaTotal + areas[i];
            }

            return areaTotal;
        }

        public bool ValidarArea(int areaTotal)
        {
            int areaCanvas = ancho * alto;
            if(areaCanvas >= areaTotal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] ListarFigurasDiferentes(int[] areas, string[] tipos, string[] textos, int[] espaciosTextos) 
        {
            List<string> listaFigurasDiferentes = new List<string>();

            for (int i = 0; i < espaciosTextos.Length; i++) 
            {
                int longitudTexto = LongitudTexto(textos[i]);
                bool validarText = ValidarTexto(espaciosTextos[i], longitudTexto);

                if (!validarText)
                {
                    string errorTextoFigura = "La figura " + tipos[i] + " tiene un espacio " + ((espaciosTextos[i] / 3) * 2) + " y el texto '" + textos[i] + "' tiene un espacio de " + longitudTexto;
                    listaFigurasDiferentes.Add(errorTextoFigura);
                }
            }

            string[] figurasDiferentes = listaFigurasDiferentes.ToArray();

            return figurasDiferentes;
        }

        public int LongitudTexto(string texto)
        {
            double longitudTexto = fuente * tamPuntoPixel * texto.Length;
            return (int)longitudTexto;
        }

        public bool ValidarTexto(int espacio, int longitudTexto)
        {
            double espacioFigura = (espacio / 3) * 2;
            if(espacioFigura >= longitudTexto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}