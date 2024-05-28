using espacioEmpleado;
Empleado[] empleados = new Empleado[3];
            // Aquí puedes agregar el código para cargar los datos de los empleados

            double totalSalarios = 0;
            foreach (Empleado empleado in empleados)
            {
                totalSalarios += empleado.SalarioFinal();
            }
            Console.WriteLine($"El monto total de salarios es: {totalSalarios}");

            Empleado masProximoAJubilarse = null;
            foreach (Empleado empleado in empleados)
            {
                if (masProximoAJubilarse == null || empleado.EdadParaJubilarse() < masProximoAJubilarse.EdadParaJubilarse())
                {
                    masProximoAJubilarse = empleado;
                }
            }
            Console.WriteLine($"El empleado más próximo a jubilarse es: {masProximoAJubilarse.Nombre} {masProximoAJubilarse.Apellido}");