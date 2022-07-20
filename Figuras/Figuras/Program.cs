using Libreria;

namespace Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

            Json json = new Json();
            bool jsonValido = json.ValidarJson();

            if (jsonValido)
            {

                Canvas Canva = new Canvas();

                Canva.ancho = 90;
                Canva.alto = 90;
                Canva.fuente = 10;

                List<IFigura> figuras = json.ProcesarJson();

                List<int> listArea = new List<int>();
                List<string> listTipo = new List<string>();
                List<string> listTexto = new List<string>();
                List<int> listEspacio = new List<int>();

                foreach (IFigura fig in figuras)
                {
                    listArea.Add(fig.CalcularArea(fig.Caracteristicas));
                    listTipo.Add(fig.Tipo);
                    listTexto.Add(fig.Texto);
                    listEspacio.Add(fig.CalcularEspacioDisponible(fig.Caracteristicas));
                }

                int[] areas = listArea.ToArray();
                string[] tipos = listTipo.ToArray();
                string[] textos = listTexto.ToArray();
                int[] espaciosTextos = listEspacio.ToArray();

                Console.WriteLine(Canva.procesar(areas, tipos, textos, espaciosTextos));
            
            }
            else
            {
                Console.WriteLine("No Valido, revisar el Archivo Json");
            }

        }
    }

}