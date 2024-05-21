namespace espacioCalculdora
{
    public class Calculadora
    {
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
        private Double resultado;
        public double Resultado{
            get;
            set;
        }
    }
}