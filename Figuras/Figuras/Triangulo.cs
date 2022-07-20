namespace Aplicacion
{
    public class Triangulo : IFigura
    {
        public string Tipo { get; set; }
        public string Texto { get; set; }
        public string Caracteristicas { get; set; }

        public int CalcularArea(string caracteristicas)
        {
            string preA = caracteristicas.Split(';')[0];
            string preB = caracteristicas.Split(';')[1];
            string preC = caracteristicas.Split(';')[2];
            int a = Int32.Parse(preA.Split('=')[1]);
            int b = Int32.Parse(preB.Split('=')[1]);
            int c = Int32.Parse(preC.Split('=')[1]);

            double Total = (a + b + c) / 2;

            double area = Math.Sqrt(Total * (Total - a) * (Total - b) * (Total - c));
            return (int)area;
        }

        public int CalcularEspacioDisponible(string caracteristicas)
        {
            string preB = caracteristicas.Split(';')[1];
            int b = Int32.Parse(preB.Split('=')[1]);
            return b;
        }
    }
}
