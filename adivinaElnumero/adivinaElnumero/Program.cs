using System;

    namespace JuegoAdivinaNumero
    {
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Bienvenido al juego Adivina el Número!");
                Console.WriteLine("Estoy pensando en un número entre 1 y 100.");
                Console.WriteLine("Intenta adivinarlo.");

                Random random = new Random();
                int numeroObjetivo = random.Next(1, 101);
                int intentos = 0;
                int intentoUsuario;

                do
                {
                    Console.Write("Ingresa tu intento: ");
                    while (!int.TryParse(Console.ReadLine(), out intentoUsuario))
                    {
                        Console.WriteLine("Por favor, ingresa un número válido.");
                    }

                    intentos++;

                    if (intentoUsuario < numeroObjetivo)
                    {
                        Console.WriteLine("El número es mayor. Intenta de nuevo.");
                    }
                    else if (intentoUsuario > numeroObjetivo)
                    {
                        Console.WriteLine("El número es menor. Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
                    }

                } while (intentoUsuario != numeroObjetivo);

                Console.WriteLine("Gracias por jugar. Presiona cualquier tecla para salir.");
                Console.ReadKey();
            }
        }
    }







