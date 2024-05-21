namespace espacioCalculdora
{
    public class Calculadora
    {
        private Double resultado;
        public double dato;
        public void Sumar(double termino){
            resultado = dato + termino;
        }
        public void Restar(double termino){
            resultado = dato - termino;
        }
        public void Multiplicar(double termino){
            resultado = dato * termino;
        }
        public void Dividir(double termino){
            resultado = dato / termino;
        }
        public void limpiar(){
            resultado = 0;
        }
        public double Resultado{
            get;
            set;
        }
    }
}