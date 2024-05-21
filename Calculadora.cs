namespace espacioCalculdora
{
    public class Calculadora
    {
        private Double resultado;
        public double Resultado
        {
            get;
            set;
        }
        private Double dato;
        public double Dato
        {
            get;
            set;
        }
        public void Asignar()
        {
            dato = Dato;
        }
        public void Sumar(double termino)
        {
            resultado = dato + termino;
            Resultado = resultado;
        }
        public void Restar(double termino)
        {
            resultado = dato - termino;
            Resultado = resultado;
        }
        public void Multiplicar(double termino)
        {
            resultado = dato * termino;
            Resultado = resultado;
        }
        public void Dividir(double termino)
        {
            resultado = dato / termino;
            Resultado = resultado;
        }
        public void limpiar()
        {
            resultado = 0;
            Resultado = resultado;
        }
    }
}