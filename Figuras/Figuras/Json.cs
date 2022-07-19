using Newtonsoft.Json;

namespace Aplicacion
{
    public class Json
    {
        public bool ValidarJson()
        {

            try 
            {
                
                StreamReader r = new StreamReader("Figura.json");
                string jsonString = r.ReadToEnd();

                ModelLista jsonObjecto = JsonConvert.DeserializeObject<ModelLista>(jsonString);
                bool error = false;

                foreach (ModelFigura fig in jsonObjecto.Lista)
                {
                    if (fig.Tipo != "circulo" && fig.Tipo != "rectangulo" && fig.Tipo != "triangulo" && fig.Tipo != "pentagono") 
                    {
                        error = true;
                    }
                }

                return !error;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public List<IFigura> ProcesarJson()
        {

            Formas figura = new Formas();
            List<IFigura> figuras = new List<IFigura>();

            StreamReader r = new StreamReader("Figura.json");
            string jsonString = r.ReadToEnd();

            ModelLista jsonObjecto = JsonConvert.DeserializeObject<ModelLista>(jsonString);

            foreach (ModelFigura fig in jsonObjecto.Lista)
            {

                IFigura instanciaFigura = figura.GenerarFigura(fig.Tipo);
                instanciaFigura.Tipo = fig.Tipo;
                instanciaFigura.Texto = fig.Texto;
                instanciaFigura.Caracteristicas = fig.Caracteristicas;
                figuras.Add(instanciaFigura);

            }

            return figuras;

        }
    }
}
