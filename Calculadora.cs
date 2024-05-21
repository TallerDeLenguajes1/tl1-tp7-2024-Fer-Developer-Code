namespace espacioCalculdora
{
    public class Calculadora
    {
        private double resultado;
        public double Resultado { get => resultado;}
        private double dato;
        public double Dato { set => dato = value; }

        public void Sumar(double termino)
        {
            resultado = dato + termino;
        }
        public void Restar(double termino)
        {
            resultado = dato - termino;
        }
        public void Multiplicar(double termino)
        {
            resultado = dato * termino;

        }
        public void Dividir(double termino)
        {
            resultado = dato / termino;
        }
        public void limpiar()
        {
            resultado = 0;
        }
    }
}