using System;

namespace Trabajo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu = 0;

            while (opcionMenu != 9)
            {
                Console.WriteLine("---------------- MENU ----------------");
                Console.WriteLine("1. Promedio de calificaciones");
                Console.WriteLine("2. Divisores de un numero");
                Console.WriteLine("3. Potenciacion");
                Console.WriteLine("4. Evaluacion del atleta");
                Console.WriteLine("5. Encuesta servicio militar");
                Console.WriteLine("6. Contar 40 numeros");
                Console.WriteLine("7. Muestreo de 70 personas");
                Console.WriteLine("8. Calcomanias de autos");
                Console.WriteLine("9. Salir");
                Console.Write("Ingrese opcion: ");
                opcionMenu = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcionMenu)
                {
                    case 1:
                        double sumaCalificaciones = 0;
                        int contadorNotas = 0;
                        string seguir = "s";

                        while (seguir == "s" || seguir == "S")
                        {
                            Console.Write("Ingrese la calificacion: ");
                            double calificacion = double.Parse(Console.ReadLine());
                            sumaCalificaciones = sumaCalificaciones + calificacion;
                            contadorNotas = contadorNotas + 1;

                            Console.Write("Desea ingresar otra calificacion? (s/n): ");
                            seguir = Console.ReadLine();
                        }

                        if (contadorNotas > 0)
                        {
                            double promedioNotas = sumaCalificaciones / contadorNotas;
                            Console.WriteLine("El promedio de calificaciones es: " + promedioNotas);
                        }
                        else
                        {
                            Console.WriteLine("No se ingresaron notas.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese un numero entero: ");
                        int numeroIngresado = int.Parse(Console.ReadLine());

                        Console.WriteLine("Divisores:");
                        for (int i = numeroIngresado; i >= 1; i = i - 1)
                        {
                            if (numeroIngresado % i == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;

                    case 3:
                        string escape = "s";

                        while (escape != "n" && escape != "N")
                        {
                            Console.Write("Ingrese la base (b): ");
                            int baseNumero = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese el exponente (e): ");
                            int exponenteNumero = int.Parse(Console.ReadLine());

                            int potencia = 1;
                            for (int i = 1; i <= exponenteNumero; i = i + 1)
                            {
                                potencia = potencia * baseNumero;
                            }

                            Console.WriteLine("Resultado de la potenciacion: " + potencia);

                            Console.Write("Desea continuar? (presione cualquier tecla o 'n' para salir): ");
                            escape = Console.ReadLine();
                        }
                        break;

                    case 4:
                        double sumaTiempos = 0;
                        bool mayorA20 = false;
                        bool menorA15 = false;

                        for (int dia = 1; dia <= 10; dia = dia + 1)
                        {
                            Console.Write("Ingrese el tiempo del dia " + dia + ": ");
                            double tiempoDia = double.Parse(Console.ReadLine());

                            sumaTiempos = sumaTiempos + tiempoDia;

                            if (tiempoDia > 20)
                            {
                                mayorA20 = true;
                            }

                            if (tiempoDia < 15)
                            {
                                menorA15 = true;
                            }
                        }

                        double promedioAtleta = sumaTiempos / 10;
                        Console.WriteLine("Promedio del atleta: " + promedioAtleta);

                        if (mayorA20 == false && menorA15 == true && promedioAtleta <= 18)
                        {
                            Console.WriteLine("El atleta SI es apto para la competencia.");
                        }
                        else
                        {
                            Console.WriteLine("El atleta NO es apto para la competencia.");
                        }
                        break;

                    case 5:
                        Console.Write("Ingrese la cantidad de personas encuestadas (n): ");
                        int totalPersonas = int.Parse(Console.ReadLine());

                        int aFavor = 0;
                        int enContra = 0;
                        int noResponde = 0;

                        int contadorEncuesta = 1;
                        while (contadorEncuesta <= totalPersonas)
                        {
                            Console.WriteLine("Persona " + contadorEncuesta + ":");
                            Console.WriteLine("1. A favor");
                            Console.WriteLine("2. En contra");
                            Console.WriteLine("3. No responde");
                            Console.Write("Ingrese su opcion (1, 2 o 3): ");
                            int voto = int.Parse(Console.ReadLine());

                            if (voto == 1)
                            {
                                aFavor = aFavor + 1;
                            }
                            else if (voto == 2)
                            {
                                enContra = enContra + 1;
                            }
                            else if (voto == 3)
                            {
                                noResponde = noResponde + 1;
                            }
                            else
                            {
                                Console.WriteLine("Opcion invalida, se toma como no responde.");
                                noResponde = noResponde + 1;
                            }

                            contadorEncuesta = contadorEncuesta + 1;
                        }

                        if (totalPersonas > 0)
                        {
                            double porcentajeFavor = (aFavor * 100.0) / totalPersonas;
                            double porcentajeContra = (enContra * 100.0) / totalPersonas;
                            double porcentajeNoResponde = (noResponde * 100.0) / totalPersonas;

                            Console.WriteLine("Porcentaje a favor: " + porcentajeFavor + "%");
                            Console.WriteLine("Porcentaje en contra: " + porcentajeContra + "%");
                            Console.WriteLine("Porcentaje no responde: " + porcentajeNoResponde + "%");
                        }
                        break;

                    case 6:
                        int contadorPositivos = 0;
                        int contadorNegativos = 0;
                        int contadorNeutros = 0;
                        double sumaPositivos = 0;
                        double sumaNegativos = 0;

                        for (int k = 1; k <= 40; k = k + 1)
                        {
                            Console.Write("Ingrese el numero " + k + ": ");
                            double valorNumero = double.Parse(Console.ReadLine());

                            if (valorNumero > 0)
                            {
                                contadorPositivos = contadorPositivos + 1;
                                sumaPositivos = sumaPositivos + valorNumero;
                            }
                            else if (valorNumero < 0)
                            {
                                contadorNegativos = contadorNegativos + 1;
                                sumaNegativos = sumaNegativos + valorNumero;
                            }
                            else
                            {
                                contadorNeutros = contadorNeutros + 1;
                            }
                        }

                        Console.WriteLine("Positivos: " + contadorPositivos);
                        Console.WriteLine("Negativos: " + contadorNegativos);
                        Console.WriteLine("Neutros (0): " + contadorNeutros);
                        Console.WriteLine("Suma de positivos: " + sumaPositivos);
                        Console.WriteLine("Suma de negativos: " + sumaNegativos);
                        break;

                    case 7:
                        int cantidadNinos = 0;
                        int cantidadJovenes = 0;
                        int cantidadAdultos = 0;
                        int cantidadViejos = 0;

                        double pesoNinos = 0;
                        double pesoJovenes = 0;
                        double pesoAdultos = 0;
                        double pesoViejos = 0;

                        for (int p = 1; p <= 70; p = p + 1)
                        {
                            Console.WriteLine("Persona " + p + ":");
                            Console.Write("Edad: ");
                            int edadPersona = int.Parse(Console.ReadLine());
                            Console.Write("Peso: ");
                            double pesoPersona = double.Parse(Console.ReadLine());

                            if (edadPersona >= 0 && edadPersona <= 13)
                            {
                                cantidadNinos = cantidadNinos + 1;
                                pesoNinos = pesoNinos + pesoPersona;
                            }
                            else if (edadPersona >= 14 && edadPersona <= 30)
                            {
                                cantidadJovenes = cantidadJovenes + 1;
                                pesoJovenes = pesoJovenes + pesoPersona;
                            }
                            else if (edadPersona >= 31 && edadPersona <= 60)
                            {
                                cantidadAdultos = cantidadAdultos + 1;
                                pesoAdultos = pesoAdultos + pesoPersona;
                            }
                            else if (edadPersona >= 61)
                            {
                                cantidadViejos = cantidadViejos + 1;
                                pesoViejos = pesoViejos + pesoPersona;
                            }
                        }

                        if (cantidadNinos > 0)
                        {
                            double promNinos = pesoNinos / cantidadNinos;
                            Console.WriteLine("Ninos: " + cantidadNinos + " personas, Promedio peso: " + promNinos);
                        }
                        else
                        {
                            Console.WriteLine("Ninos: 0 personas");
                        }

                        if (cantidadJovenes > 0)
                        {
                            double promJovenes = pesoJovenes / cantidadJovenes;
                            Console.WriteLine("Jovenes: " + cantidadJovenes + " personas, Promedio peso: " + promJovenes);
                        }
                        else
                        {
                            Console.WriteLine("Jovenes: 0 personas");
                        }

                        if (cantidadAdultos > 0)
                        {
                            double promAdultos = pesoAdultos / cantidadAdultos;
                            Console.WriteLine("Adultos: " + cantidadAdultos + " personas, Promedio peso: " + promAdultos);
                        }
                        else
                        {
                            Console.WriteLine("Adultos: 0 personas");
                        }

                        if (cantidadViejos > 0)
                        {
                            double promViejos = pesoViejos / cantidadViejos;
                            Console.WriteLine("Viejos: " + cantidadViejos + " personas, Promedio peso: " + promViejos);
                        }
                        else
                        {
                            Console.WriteLine("Viejos: 0 personas");
                        }
                        break;

                    case 8:
                        Console.Write("Ingrese la cantidad de autos (n): ");
                        int totalAutos = int.Parse(Console.ReadLine());

                        int amarilla = 0;
                        int rosa = 0;
                        int roja = 0;
                        int verde = 0;
                        int azul = 0;

                        for (int a = 1; a <= totalAutos; a = a + 1)
                        {
                            Console.Write("Ingrese el ultimo digito de la placa del auto " + a + ": ");
                            int digito = int.Parse(Console.ReadLine());

                            if (digito == 1 || digito == 2)
                            {
                                amarilla = amarilla + 1;
                            }
                            else if (digito == 3 || digito == 4)
                            {
                                rosa = rosa + 1;
                            }
                            else if (digito == 5 || digito == 6)
                            {
                                roja = roja + 1;
                            }
                            else if (digito == 7 || digito == 8)
                            {
                                verde = verde + 1;
                            }
                            else if (digito == 9 || digito == 0)
                            {
                                azul = azul + 1;
                            }
                            else
                            {
                                Console.WriteLine("Digito no valido.");
                            }
                        }

                        Console.WriteLine("Autos con calcomania amarilla: " + amarilla);
                        Console.WriteLine("Autos con calcomania rosa: " + rosa);
                        Console.WriteLine("Autos con calcomania roja: " + roja);
                        Console.WriteLine("Autos con calcomania verde: " + verde);
                        Console.WriteLine("Autos con calcomania azul: " + azul);
                        break;

                    case 9:
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
