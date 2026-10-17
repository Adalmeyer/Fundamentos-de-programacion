using System;

namespace TallerModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu = 0;

            while (opcionMenu != 6)
            {
                Console.WriteLine("---------------- MENU MODULAR ----------------");
                Console.WriteLine("1. Vocales y consonantes en palabra");
                Console.WriteLine("2. Gestion de lista de tareas");
                Console.WriteLine("3. Conversor de unidades de medida");
                Console.WriteLine("4. Matriz de contactos (buscar y modificar)");
                Console.WriteLine("5. Juego de tres en raya (Triqui)");
                Console.WriteLine("6. Salir");
                Console.Write("Ingrese opcion: ");
                opcionMenu = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcionMenu)
                {
                    case 1:
                        EjecutarEjercicio1();
                        break;
                    case 2:
                        EjecutarEjercicio2();
                        break;
                    case 3:
                        EjecutarEjercicio3();
                        break;
                    case 4:
                        EjecutarEjercicio4();
                        break;
                    case 5:
                        EjecutarEjercicio5();
                        break;
                    case 6:
                        Console.WriteLine("Fin del programa.");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void EjecutarEjercicio1()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            char[] vectorLetras = PasarPalabraAVector(palabra);
            int cantidadVocales = ContarVocales(vectorLetras);
            int cantidadConsonantes = ContarConsonantes(vectorLetras);

            Console.WriteLine("Cantidad de vocales: " + cantidadVocales);
            Console.WriteLine("Cantidad de consonantes: " + cantidadConsonantes);
        }

        static char[] PasarPalabraAVector(string palabra)
        {
            char[] letras = new char[palabra.Length];
            for (int i = 0; i < palabra.Length; i = i + 1)
            {
                letras[i] = palabra[i];
            }
            return letras;
        }

        static int ContarVocales(char[] letras)
        {
            int vocales = 0;
            for (int i = 0; i < letras.Length; i = i + 1)
            {
                char c = char.ToLower(letras[i]);
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vocales = vocales + 1;
                }
            }
            return vocales;
        }

        static int ContarConsonantes(char[] letras)
        {
            int consonantes = 0;
            for (int i = 0; i < letras.Length; i = i + 1)
            {
                char c = char.ToLower(letras[i]);
                if (c >= 'a' && c <= 'z')
                {
                    if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                    {
                        consonantes = consonantes + 1;
                    }
                }
            }
            return consonantes;
        }

        static void EjecutarEjercicio2()
        {
            string[] tareas = new string[50];
            int cantidadTareas = 0;
            int opcionTareas = 0;

            while (opcionTareas != 4)
            {
                Console.WriteLine("-- Submenu Tareas --");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Mostrar tareas");
                Console.WriteLine("4. Regresar al menu principal");
                Console.Write("Seleccione opcion: ");
                opcionTareas = int.Parse(Console.ReadLine());

                if (opcionTareas == 1)
                {
                    AgregarTarea(tareas, ref cantidadTareas);
                }
                else if (opcionTareas == 2)
                {
                    EliminarTarea(tareas, ref cantidadTareas);
                }
                else if (opcionTareas == 3)
                {
                    MostrarTareas(tareas, cantidadTareas);
                }
                Console.WriteLine();
            }
        }

        static void AgregarTarea(string[] tareas, ref int total)
        {
            if (total < tareas.Length)
            {
                Console.Write("Ingrese la descripcion de la tarea: ");
                string nueva = Console.ReadLine();
                tareas[total] = nueva;
                total = total + 1;
                Console.WriteLine("Tarea agregada correctamente.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar mas tareas, lista llena.");
            }
        }

        static void EliminarTarea(string[] tareas, ref int total)
        {
            if (total == 0)
            {
                Console.WriteLine("No hay tareas para eliminar.");
            }
            else
            {
                MostrarTareas(tareas, total);
                Console.Write("Ingrese el numero de la tarea a eliminar: ");
                int indice = int.Parse(Console.ReadLine());

                if (indice >= 1 && indice <= total)
                {
                    for (int i = indice - 1; i < total - 1; i = i + 1)
                    {
                        tareas[i] = tareas[i + 1];
                    }
                    total = total - 1;
                    Console.WriteLine("Tarea eliminada.");
                }
                else
                {
                    Console.WriteLine("Numero de tarea no valido.");
                }
            }
        }

        static void MostrarTareas(string[] tareas, int total)
        {
            if (total == 0)
            {
                Console.WriteLine("La lista de tareas esta vacia.");
            }
            else
            {
                Console.WriteLine("Lista de tareas:");
                for (int i = 0; i < total; i = i + 1)
                {
                    Console.WriteLine((i + 1) + ". " + tareas[i]);
                }
            }
        }

        static void EjecutarEjercicio3()
        {
            Console.WriteLine("Tipos de unidades de medida:");
            Console.WriteLine("1. Masa");
            Console.WriteLine("2. Capacidad");
            Console.WriteLine("3. Longitud");
            Console.WriteLine("4. Tiempo");
            Console.Write("Seleccione tipo: ");
            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.WriteLine("1. De kilogramos a gramos");
                Console.WriteLine("2. De gramos a kilogramos");
                Console.Write("Seleccione conversion: ");
                int subOpcion = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor a convertir: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = ConvertirMasa(valor, subOpcion);

                if (subOpcion == 1)
                {
                    Console.WriteLine(valor + " kilogramos son " + resultado + " gramos");
                }
                else
                {
                    Console.WriteLine(valor + " gramos son " + resultado + " kilogramos");
                }
            }
            else if (tipo == 2)
            {
                Console.WriteLine("1. De litro a mililitro");
                Console.WriteLine("2. De mililitro a litro");
                Console.Write("Seleccione conversion: ");
                int subOpcion = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor a convertir: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = ConvertirCapacidad(valor, subOpcion);

                if (subOpcion == 1)
                {
                    Console.WriteLine(valor + " litros son " + resultado + " mililitros");
                }
                else
                {
                    Console.WriteLine(valor + " mililitros son " + resultado + " litros");
                }
            }
            else if (tipo == 3)
            {
                Console.WriteLine("1. De kilometro a metro");
                Console.WriteLine("2. De metro a kilometro");
                Console.Write("Seleccione conversion: ");
                int subOpcion = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor a convertir: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = ConvertirLongitud(valor, subOpcion);

                if (subOpcion == 1)
                {
                    Console.WriteLine(valor + " kilometros son " + resultado + " metros");
                }
                else
                {
                    Console.WriteLine(valor + " metros son " + resultado + " kilometros");
                }
            }
            else if (tipo == 4)
            {
                Console.WriteLine("1. De hora a segundos");
                Console.WriteLine("2. De segundos a hora");
                Console.Write("Seleccione conversion: ");
                int subOpcion = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el valor a convertir: ");
                double valor = double.Parse(Console.ReadLine());
                double resultado = ConvertirTiempo(valor, subOpcion);

                if (subOpcion == 1)
                {
                    Console.WriteLine(valor + " horas son " + resultado + " segundos");
                }
                else
                {
                    Console.WriteLine(valor + " segundos son " + resultado + " horas");
                }
            }
            else
            {
                Console.WriteLine("Tipo de unidad invalido.");
            }
        }

        static double ConvertirMasa(double valor, int tipo)
        {
            if (tipo == 1)
            {
                return valor * 1000;
            }
            else
            {
                return valor / 1000;
            }
        }

        static double ConvertirCapacidad(double valor, int tipo)
        {
            if (tipo == 1)
            {
                return valor * 1000;
            }
            else
            {
                return valor / 1000;
            }
        }

        static double ConvertirLongitud(double valor, int tipo)
        {
            if (tipo == 1)
            {
                return valor * 1000;
            }
            else
            {
                return valor / 1000;
            }
        }

        static double ConvertirTiempo(double valor, int tipo)
        {
            if (tipo == 1)
            {
                return valor * 3600;
            }
            else
            {
                return valor / 3600;
            }
        }

        static void EjecutarEjercicio4()
        {
            Console.Write("Ingrese filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());

            string[,] contactos = new string[filas, columnas];
            LlenarMatrizContactos(contactos, filas, columnas);

            Console.WriteLine();
            MostrarMatrizContactos(contactos, filas, columnas);

            Console.WriteLine();
            Console.Write("Ingrese el nombre del contacto a buscar: ");
            string nombreBuscado = Console.ReadLine();

            Console.Write("Ingrese el nuevo nombre para cambiarlo: ");
            string nuevoNombre = Console.ReadLine();

            BuscarYModificarContacto(contactos, filas, columnas, nombreBuscado, nuevoNombre);

            Console.WriteLine();
            MostrarMatrizContactos(contactos, filas, columnas);
        }

        static void LlenarMatrizContactos(string[,] matriz, int filas, int columnas)
        {
            for (int f = 0; f < filas; f = f + 1)
            {
                for (int c = 0; c < columnas; c = c + 1)
                {
                    Console.Write("Ingrese contacto [" + f + ", " + c + "]: ");
                    matriz[f, c] = Console.ReadLine();
                }
            }
        }

        static void BuscarYModificarContacto(string[,] matriz, int filas, int columnas, string buscado, string nuevo)
        {
            bool encontrado = false;

            for (int f = 0; f < filas; f = f + 1)
            {
                for (int c = 0; c < columnas; c = c + 1)
                {
                    if (matriz[f, c].ToLower() == buscado.ToLower())
                    {
                        encontrado = true;
                        Console.WriteLine("Nombre encontrado: " + matriz[f, c]);
                        Console.WriteLine("Posicion en la matriz: (" + f + ", " + c + ")");
                        matriz[f, c] = nuevo;
                        Console.WriteLine("Nuevo nombre ingresado: " + nuevo);
                    }
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("El nombre no fue encontrado en la matriz.");
            }
        }

        static void MostrarMatrizContactos(string[,] matriz, int filas, int columnas)
        {
            Console.WriteLine("Matriz de contactos:");
            for (int f = 0; f < filas; f = f + 1)
            {
                for (int c = 0; c < columnas; c = c + 1)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void EjecutarEjercicio5()
        {
            char[,] tablero = new char[3, 3];
            InicializarTablero(tablero);

            char turno = 'X';
            bool juegoTerminado = false;

            while (juegoTerminado == false)
            {
                DibujarTablero(tablero);
                Console.WriteLine("Turno del jugador: " + turno);
                Console.Write("Ingrese fila (0 a 2): ");
                int fila = int.Parse(Console.ReadLine());
                Console.Write("Ingrese columna (0 a 2): ");
                int columna = int.Parse(Console.ReadLine());

                bool movValido = RealizarMovimiento(tablero, fila, columna, turno);

                if (movValido == true)
                {
                    bool hayGanador = VerificarGanador(tablero, turno);

                    if (hayGanador == true)
                    {
                        DibujarTablero(tablero);
                        Console.WriteLine("El jugador " + turno + " ha ganado!");
                        juegoTerminado = true;
                    }
                    else if (TableroLleno(tablero) == true)
                    {
                        DibujarTablero(tablero);
                        Console.WriteLine("Empate, no hay mas casillas libres.");
                        juegoTerminado = true;
                    }
                    else
                    {
                        if (turno == 'X')
                        {
                            turno = 'O';
                        }
                        else
                        {
                            turno = 'X';
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Casilla ocupada o coordenadas fuera de rango. Intente de nuevo.");
                }

                Console.WriteLine();
            }
        }

        static void InicializarTablero(char[,] tablero)
        {
            for (int f = 0; f < 3; f = f + 1)
            {
                for (int c = 0; c < 3; c = c + 1)
                {
                    tablero[f, c] = '-';
                }
            }
        }

        static void DibujarTablero(char[,] tablero)
        {
            Console.WriteLine("Tablero:");
            for (int f = 0; f < 3; f = f + 1)
            {
                for (int c = 0; c < 3; c = c + 1)
                {
                    Console.Write(tablero[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool RealizarMovimiento(char[,] tablero, int fila, int columna, char ficha)
        {
            if (fila >= 0 && fila < 3 && columna >= 0 && columna < 3)
            {
                if (tablero[fila, columna] == '-')
                {
                    tablero[fila, columna] = ficha;
                    return true;
                }
            }
            return false;
        }

        static bool VerificarGanador(char[,] tablero, char ficha)
        {
            for (int f = 0; f < 3; f = f + 1)
            {
                if (tablero[f, 0] == ficha && tablero[f, 1] == ficha && tablero[f, 2] == ficha)
                {
                    return true;
                }
            }

            for (int c = 0; c < 3; c = c + 1)
            {
                if (tablero[0, c] == ficha && tablero[1, c] == ficha && tablero[2, c] == ficha)
                {
                    return true;
                }
            }

            if (tablero[0, 0] == ficha && tablero[1, 1] == ficha && tablero[2, 2] == ficha)
            {
                return true;
            }

            if (tablero[0, 2] == ficha && tablero[1, 1] == ficha && tablero[2, 0] == ficha)
            {
                return true;
            }

            return false;
        }

        static bool TableroLleno(char[,] tablero)
        {
            for (int f = 0; f < 3; f = f + 1)
            {
                for (int c = 0; c < 3; c = c + 1)
                {
                    if (tablero[f, c] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
