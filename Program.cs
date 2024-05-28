using espacioEmpleado;

// Inicializar el primer empleado
Empleado empleado1 = new Empleado();
empleado1.Nombre = "Juan";
empleado1.Apellido = "Pérez";
empleado1.FechaNacimiento = new DateTime(1980, 5, 1);
empleado1.EstadoCivil = 'C';
empleado1.FechaIngreso = new DateTime(2000, 1, 1);
empleado1.Sueldo = 50000;
empleado1.Posicion = Empleado.Cargo.Ingeniero;

// Inicializar el segundo empleado
Empleado empleado2 = new Empleado();
empleado2.Nombre = "María";
empleado2.Apellido = "González";
empleado2.FechaNacimiento = new DateTime(1985, 6, 15);
empleado2.EstadoCivil = 'S';
empleado2.FechaIngreso = new DateTime(2005, 1, 1);
empleado2.Sueldo = 45000;
empleado2.Posicion = Empleado.Cargo.Administrativo;

// Inicializar el tercer empleado
Empleado empleado3 = new Empleado();
empleado3.Nombre = "Carlos";
empleado3.Apellido = "Rodríguez";
empleado3.FechaNacimiento = new DateTime(1975, 7, 30);
empleado3.EstadoCivil = 'C';
empleado3.FechaIngreso = new DateTime(1995, 1, 1);
empleado3.Sueldo = 55000;
empleado3.Posicion = Empleado.Cargo.Especialista;