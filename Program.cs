using espacioCalculdora;
int opcion = 1;
int seguirOperando = 1;
double termino = 0;
double dato = 0;
string linea;
do
{
    Console.WriteLine("Inserte el valor con el que va a operar en dato");
    linea = Console.ReadLine();
    if (double.TryParse(linea, out dato))
    {
        Calculadora calculo = new Calculadora();
        calculo.Dato = dato;
        Console.WriteLine("Ingrese un segundo numero");
        linea = Console.ReadLine();
        if (double.TryParse(linea, out termino))
        {
            Console.WriteLine("Que tipo de operacion desea realizar?\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
            linea = Console.ReadLine();
            if (int.TryParse(linea, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        calculo.Asignar();
                        calculo.Sumar(termino);
                        break;
                    case 2:
                        calculo.Asignar();
                        calculo.Restar(termino);
                        break;
                    case 3:
                        calculo.Asignar();
                        calculo.Multiplicar(termino);
                        break;
                    case 4:
                        calculo.Asignar();
                        calculo.Dividir(termino);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Inserte un valor valido");
                        break;
                }
                Console.WriteLine($"El resultado es: {calculo.Resultado}");
                calculo.limpiar();
                Console.WriteLine("Desea realizar otra operacion?\n1.Si\n2.No");
                linea = Console.ReadLine();
                if (int.TryParse(linea, out seguirOperando))
                {
                    if (seguirOperando == 2)
                    {
                        seguirOperando = 2;
                        Console.WriteLine("Gracias por usar la calculadora");
                    }
                }
            }
            else
            {
                Console.WriteLine("Inserte un valor valido");
            }
        }
        else
        {
            Console.WriteLine("Inserte un valor valido");
        }
    }
    else
    {
        Console.WriteLine("Inserte un valor valido");
    }
} while (seguirOperando == 1);