namespace espacioEmpleado
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldo;
        private Cargo posicion;

        public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public Cargo Posicion { get => posicion; set => posicion = value; }

        public int Antiguedad()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }

        public int EdadEmpleado()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }

        public int EdadParaJubilarse()
        {
            return 65 - EdadEmpleado();
        }

        public double SalarioFinal()
        {
            double adicional = Sueldo * 0.01 * Math.Min(Antiguedad(), 20);
            if (Posicion == Cargo.Ingeniero || Posicion == Cargo.Especialista)
            {
                adicional *= 1.5;
            }
            if (EstadoCivil == 'C')
            {
                adicional += 150000;
            }
            return Sueldo + adicional;
        }
    }
}
