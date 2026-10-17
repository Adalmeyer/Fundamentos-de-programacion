using System;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu = 0;

            while (opcionMenu != 7)
            {
                Console.WriteLine("---------------- MENU MATRICES ----------------");
                Console.WriteLine("1. Matriz 10x20 y suma de columnas");
                Console.WriteLine("2. Matriz nxm intercambio primera y ultima fila");
                Console.WriteLine("3. Frecuencia del 1 al 10 en matriz 5x5");
                Console.WriteLine("4. Juego tablero 5x5 adivinar X");
                Console.WriteLine("5. Matriz nxm y conversion de filas a columnas");
                Console.WriteLine("6. Matriz nxm aleatorios del 1 al 3 y frecuencias");
                Console.WriteLine("7. Salir");
                Console.Write("Ingrese opcion: ");
                opcionMenu = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcionMenu)
                {
                    case 1:
                        int[,] matriz1 = new int[10, 20];
                        Random aleatorio1 = new Random();

                        Console.WriteLine("Matriz generada (10 filas x 20 columnas):");
                        for (int f = 0; f < 10; f = f + 1)
                        {
                            for (int c = 0; c < 20; c = c + 1)
                            {
                                matriz1[f, c] = aleatorio1.Next(1, 10);
                                Console.Write(matriz1[f, c] + "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        for (int c = 0; c < 20; c = c + 1)
                        {
                            int sumaColumna = 0;
                            for (int f = 0; f < 10; f = f + 1)
                            {
                                sumaColumna = sumaColumna + matriz1[f, c];
                            }
                            Console.WriteLine("Suma de la columna " + (c + 1) + ": " + sumaColumna);
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese cantidad de filas (n): ");
                        int filas2 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese cantidad de columnas (m): ");
                        int columnas2 = int.Parse(Console.ReadLine());

                        char[,] matrizOriginal2 = new char[filas2, columnas2];
                        char[,] matrizCopia2 = new char[filas2, columnas2];

                        for (int f = 0; f < filas2; f = f + 1)
                        {
                            for (int c = 0; c < columnas2; c = c + 1)
                            {
                                Console.Write("Ingrese caracter para posicion [" + f + ", " + c + "]: ");
                                char caracterLeido = char.Parse(Console.ReadLine());
                                matrizOriginal2[f, c] = caracterLeido;
                                matrizCopia2[f, c] = caracterLeido;
                            }
                        }

                        for (int c = 0; c < columnas2; c = c + 1)
                        {
                            char temporal = matrizCopia2[0, c];
                            matrizCopia2[0, c] = matrizCopia2[filas2 - 1, c];
                            matrizCopia2[filas2 - 1, c] = temporal;
                        }

                        Console.WriteLine();
                        Console.WriteLine("Matriz Original:");
                        for (int f = 0; f < filas2; f = f + 1)
                        {
                            for (int c = 0; c < columnas2; c = c + 1)
                            {
                                Console.Write(matrizOriginal2[f, c] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Matriz con intercambio de primera y ultima fila:");
                        for (int f = 0; f < filas2; f = f + 1)
                        {
                            for (int c = 0; c < columnas2; c = c + 1)
                            {
                                Console.Write(matrizCopia2[f, c] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        int[,] matriz3 = new int[5, 5];
                        int[] frecuencia3 = new int[11];
                        Random aleatorio3 = new Random();

                        for (int f = 0; f < 5; f = f + 1)
                        {
                            for (int c = 0; c < 5; c = c + 1)
                            {
                                int numeroAleatorio = aleatorio3.Next(1, 11);
                                matriz3[f, c] = numeroAleatorio;
                                frecuencia3[numeroAleatorio] = frecuencia3[numeroAleatorio] + 1;
                            }
                        }

                        Console.WriteLine("Matriz 5x5:");
                        for (int f = 0; f < 5; f = f + 1)
                        {
                            for (int c = 0; c < 5; c = c + 1)
                            {
                                Console.Write(matriz3[f, c] + "\t");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Frecuencia de cada numero (1 al 10):");
                        for (int num = 1; num <= 10; num = num + 1)
                        {
                            Console.WriteLine("Numero " + num + ": " + frecuencia3[num] + " veces");
                        }
                        break;

                    case 4:
                        char[,] tablero4 = new char[5, 5];
                        for (int f = 0; f < 5; f = f + 1)
                        {
                            for (int c = 0; c < 5; c = c + 1)
                            {
                                tablero4[f, c] = '-';
                            }
                        }

                        Random aleatorio4 = new Random();
                        int xColocadas = 0;
                        while (xColocadas < 3)
                        {
                            int filaX = aleatorio4.Next(0, 5);
                            int colX = aleatorio4.Next(0, 5);
                            if (tablero4[filaX, colX] != 'X')
                            {
                                tablero4[filaX, colX] = 'X';
                                xColocadas = xColocadas + 1;
                            }
                        }

                        bool acertoJuego = false;
                        int filaGanadora = -1;
                        int colGanadora = -1;

                        for (int intento = 1; intento <= 3; intento = intento + 1)
                        {
                            if (acertoJuego == false)
                            {
                                Console.WriteLine("Intento " + intento + " de 3");
                                Console.Write("Ingrese fila (0 a 4): ");
                                int filaUsuario = int.Parse(Console.ReadLine());
                                Console.Write("Ingrese columna (0 a 4): ");
                                int colUsuario = int.Parse(Console.ReadLine());

                                if (tablero4[filaUsuario, colUsuario] == 'X')
                                {
                                    acertoJuego = true;
                                    filaGanadora = filaUsuario;
                                    colGanadora = colUsuario;
                                }
                                else
                                {
                                    Console.WriteLine("No acertaste en este intento.");
                                }
                            }
                        }

                        Console.WriteLine();
                        if (acertoJuego == true)
                        {
                            Console.WriteLine("EXITO! Has acertado.");
                            Console.WriteLine("Se encontro una X en la posicion: [" + filaGanadora + ", " + colGanadora + "]");
                        }
                        else
                        {
                            Console.WriteLine("ERROR! No lograste acertar ninguna X.");
                            Console.WriteLine("El tablero completo con las X es:");
                            for (int f = 0; f < 5; f = f + 1)
                            {
                                for (int c = 0; c < 5; c = c + 1)
                                {
                                    Console.Write(tablero4[f, c] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 5:
                        Console.Write("Ingrese cantidad de filas: ");
                        int filas5 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese cantidad de columnas: ");
                        int columnas5 = int.Parse(Console.ReadLine());

                        int[,] matriz5 = new int[filas5, columnas5];
                        int[,] matrizTranspuesta5 = new int[columnas5, filas5];

                        for (int f = 0; f < filas5; f = f + 1)
                        {
                            for (int c = 0; c < columnas5; c = c + 1)
                            {
                                Console.Write("Ingrese elemento [" + f + ", " + c + "]: ");
                                matriz5[f, c] = int.Parse(Console.ReadLine());
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Matriz ingresada:");
                        for (int f = 0; f < filas5; f = f + 1)
                        {
                            for (int c = 0; c < columnas5; c = c + 1)
                            {
                                Console.Write(matriz5[f, c] + "\t");
                            }
                            Console.WriteLine();
                        }

                        for (int f = 0; f < filas5; f = f + 1)
                        {
                            for (int c = 0; c < columnas5; c = c + 1)
                            {
                                matrizTranspuesta5[c, f] = matriz5[f, c];
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Nueva matriz (filas convertidas en columnas):");
                        for (int f = 0; f < columnas5; f = f + 1)
                        {
                            for (int c = 0; c < filas5; c = c + 1)
                            {
                                Console.Write(matrizTranspuesta5[f, c] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 6:
                        Console.Write("Ingrese cantidad de filas (n): ");
                        int filas6 = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese cantidad de columnas (m): ");
                        int columnas6 = int.Parse(Console.ReadLine());

                        int[,] matriz6 = new int[filas6, columnas6];
                        Random aleatorio6 = new Random();

                        int contador1 = 0;
                        int contador2 = 0;
                        int contador3 = 0;

                        for (int f = 0; f < filas6; f = f + 1)
                        {
                            for (int c = 0; c < columnas6; c = c + 1)
                            {
                                matriz6[f, c] = aleatorio6.Next(1, 4);

                                if (matriz6[f, c] == 1)
                                {
                                    contador1 = contador1 + 1;
                                }
                                else if (matriz6[f, c] == 2)
                                {
                                    contador2 = contador2 + 1;
                                }
                                else if (matriz6[f, c] == 3)
                                {
                                    contador3 = contador3 + 1;
                                }
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Matriz generada:");
                        for (int f = 0; f < filas6; f = f + 1)
                        {
                            for (int c = 0; c < columnas6; c = c + 1)
                            {
                                Console.Write(matriz6[f, c] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("Veces que aparecio el 1: " + contador1);
                        Console.WriteLine("Veces que aparecio el 2: " + contador2);
                        Console.WriteLine("Veces que aparecio el 3: " + contador3);

                        if (contador1 > contador2 && contador1 > contador3)
                        {
                            Console.WriteLine("El numero que mas se repitio fue el 1.");
                        }
                        else if (contador2 > contador1 && contador2 > contador3)
                        {
                            Console.WriteLine("El numero que mas se repitio fue el 2.");
                        }
                        else if (contador3 > contador1 && contador3 > contador2)
                        {
                            Console.WriteLine("El numero que mas se repitio fue el 3.");
                        }
                        else
                        {
                            Console.WriteLine("Hubo empate en la mayor cantidad de repeticiones.");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Fin del programa.");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
