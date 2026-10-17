using System;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- MENU DE EJERCICIOS ----------------");
            Console.WriteLine("1. Tres numeros, mayor y ordenar");
            Console.WriteLine("2. Disparo con estado invencible y municion");
            Console.WriteLine("3. Distancia entre tres puntos y triangulo");
            Console.WriteLine("4. Movimiento horizontal del personaje");
            Console.WriteLine("5. Acciones del personaje segun vidas");
            Console.WriteLine("6. Estado del alumno (Prueba de escritorio)");
            Console.Write("Ingrese opcion: ");
            int opcionMenu = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcionMenu)
            {
                case 1:
                    Console.Write("Ingrese numero 1: ");
                    int numero1 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese numero 2: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese numero 3: ");
                    int numero3 = int.Parse(Console.ReadLine());

                    if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
                    {
                        Console.WriteLine("Se deben ingresar numeros diferentes.");
                    }
                    else
                    {
                        int numeroMayor = 0;

                        if (numero1 > numero2 && numero1 > numero3)
                        {
                            numeroMayor = numero1;
                        }
                        else if (numero2 > numero1 && numero2 > numero3)
                        {
                            numeroMayor = numero2;
                        }
                        else
                        {
                            numeroMayor = numero3;
                        }

                        Console.WriteLine("El numero mayor es: " + numeroMayor);
                        Console.WriteLine("Numeros de menor a mayor:");

                        if (numero1 < numero2 && numero2 < numero3)
                        {
                            Console.WriteLine(numero1 + ", " + numero2 + ", " + numero3);
                        }
                        else if (numero1 < numero3 && numero3 < numero2)
                        {
                            Console.WriteLine(numero1 + ", " + numero3 + ", " + numero2);
                        }
                        else if (numero2 < numero1 && numero1 < numero3)
                        {
                            Console.WriteLine(numero2 + ", " + numero1 + ", " + numero3);
                        }
                        else if (numero2 < numero3 && numero3 < numero1)
                        {
                            Console.WriteLine(numero2 + ", " + numero3 + ", " + numero1);
                        }
                        else if (numero3 < numero1 && numero1 < numero2)
                        {
                            Console.WriteLine(numero3 + ", " + numero1 + ", " + numero2);
                        }
                        else
                        {
                            Console.WriteLine(numero3 + ", " + numero2 + ", " + numero1);
                        }
                    }
                    break;

                case 2:
                    Console.Write("El personaje esta en estado invencible? (True/False): ");
                    bool estadoInvencible = bool.Parse(Console.ReadLine());

                    Random rndMunicion = new Random();
                    int municion = rndMunicion.Next(1, 11);
                    Console.WriteLine("Cantidad de municion: " + municion);

                    if (estadoInvencible == true && municion >= 1 && municion <= 10)
                    {
                        Console.WriteLine("El personaje esta disparando");
                    }
                    break;

                case 3:
                    Console.Write("Ingrese x1: ");
                    double x1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese y1: ");
                    double y1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese x2: ");
                    double x2 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese y2: ");
                    double y2 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese x3: ");
                    double x3 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese y3: ");
                    double y3 = double.Parse(Console.ReadLine());

                    double distanciaP1P2 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                    double distanciaP2P3 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
                    double distanciaP1P3 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));

                    Console.WriteLine("Distancia P1 a P2: " + distanciaP1P2);
                    Console.WriteLine("Distancia P2 a P3: " + distanciaP2P3);
                    Console.WriteLine("Distancia P1 a P3: " + distanciaP1P3);

                    if (distanciaP1P2 + distanciaP2P3 > distanciaP1P3 && distanciaP1P2 + distanciaP1P3 > distanciaP2P3 && distanciaP2P3 + distanciaP1P3 > distanciaP1P2)
                    {
                        Console.WriteLine("Si se puede construir un triangulo.");
                    }
                    else
                    {
                        Console.WriteLine("No se puede construir un triangulo.");

                        if (distanciaP1P2 + distanciaP2P3 <= distanciaP1P3)
                        {
                            Console.WriteLine("No se cumple: distancia P1->P2 + P2->P3 debe ser mayor que P1->P3");
                        }
                        if (distanciaP1P2 + distanciaP1P3 <= distanciaP2P3)
                        {
                            Console.WriteLine("No se cumple: distancia P1->P2 + P1->P3 debe ser mayor que P2->P3");
                        }
                        if (distanciaP2P3 + distanciaP1P3 <= distanciaP1P2)
                        {
                            Console.WriteLine("No se cumple: distancia P2->P3 + P1->P3 debe ser mayor que P1->P2");
                        }
                    }
                    break;

                case 4:
                    Console.Write("Ingrese tecla de movimiento ('d' derecha, 'i' izquierda): ");
                    char tecla = char.Parse(Console.ReadLine());

                    if (tecla == 'd' || tecla == 'D')
                    {
                        Console.WriteLine("El personaje se mueve hacia la derecha");
                    }
                    else if (tecla == 'i' || tecla == 'I')
                    {
                        Console.WriteLine("El personaje se mueve hacia la izquierda");
                    }
                    else
                    {
                        Console.WriteLine("No me puedo mover en otra direccion");
                    }
                    break;

                case 5:
                    Random rndVidas = new Random();
                    int vidas = rndVidas.Next(0, 6);
                    Console.WriteLine("Numero de vidas generadas: " + vidas);

                    if (vidas > 0)
                    {
                        Console.Write("Ingrese accion del personaje ('c', 'x', 't', 'i'): ");
                        char accion = char.Parse(Console.ReadLine());

                        if (accion == 'c' || accion == 'C')
                        {
                            Console.WriteLine("el personaje esta disparando");
                        }
                        else if (accion == 'x' || accion == 'X')
                        {
                            Console.WriteLine("el personaje esta hablando con la Rana");
                        }
                        else if (accion == 't' || accion == 'T')
                        {
                            Console.WriteLine("el personaje esta en modo Turbo");
                        }
                        else if (accion == 'i' || accion == 'I')
                        {
                            Console.WriteLine("el personaje es Invencible");
                        }
                        else
                        {
                            Console.WriteLine("Accion no reconocida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("el personaje no posee vidas, y no puede realizar ninguna accion");
                    }
                    break;

                case 6:
                    double finalProm;
                    string state = "Error";

                    Console.Write("Ingrese el promedio final del alumno: ");
                    finalProm = double.Parse(Console.ReadLine());

                    if (finalProm >= 0)
                    {
                        if (finalProm <= 5)
                        {
                            state = "Desaprobado";
                        }
                        else
                        {
                            if (finalProm <= 10)
                            {
                                state = "Vacacional";
                            }
                            else
                            {
                                if (finalProm <= 15)
                                {
                                    state = "Requiere mejorar";
                                }
                                else
                                {
                                    if (finalProm <= 20)
                                    {
                                        state = "Supera las expectativas";
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingrese un promedio correcto.");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un promedio correcto.");
                    }

                    Console.WriteLine("El estado del alumno es: " + state);
                    break;

                default:
                    Console.WriteLine("Opcion invalida.");
                    break;
            }
        }
    }
}
