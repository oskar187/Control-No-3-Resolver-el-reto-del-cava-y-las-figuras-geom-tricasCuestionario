namespace Aplicacion
{
    public class Rectangulo : IFigura
    {
        public string Tipo { get; set; }
        public string Texto { get; set; }
        public string Caracteristicas { get; set; }

        public int CalcularArea(string caracteristicas)
        {
            string Ancho = caracteristicas.Split(';')[0];
            string Alto = caracteristicas.Split(';')[1];
            int ancho = Int32.Parse(Ancho.Split('=')[1]);
            int alto = Int32.Parse(Alto.Split('=')[1]);
            int area = ancho * alto;
            return area;
        }

        public int CalcularEspacioDisponible(string caracteristicas)
        {
            string Ancho = caracteristicas.Split(';')[0];
            int ancho = Int32.Parse(Ancho.Split('=')[1]);
            return ancho;
        }
    }
}
