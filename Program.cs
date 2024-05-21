﻿using espacioCalculdora;
int opcion = 1;
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
            Console.WriteLine("Que tipo de operacion desea realizar?\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.Terminar");
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
            }
            else
            {
                Console.WriteLine("Inserte un valor valido");
            }
        }
    }
    else
    {
        Console.WriteLine("Inserte un valor valido");
    }
} while (opcion != 5);