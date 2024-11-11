using System;

class TeatroTitere2
{
  
    const int filas = 10;
    const int asientos = 10;

    
    static string[,] mapaAsientos = new string[filas, asientos];

    static void Main()
    {
      
        InicializarMapa();

        int opcion;
        do
        {
            Console.Clear();
            MostrarMapa();
            Console.WriteLine("1. Reservar asiento");
            Console.WriteLine("2. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ReservarAsiento();
                    break;
                case 2:
                    Console.WriteLine("Gracias por usar el sistema de reservas.");
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente nuevamente.");
                    break;
            }
        } while (opcion != 2);
    }

  
    static void InicializarMapa()
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < asientos; j++)
            {
                mapaAsientos[i, j] = "L"; // L = libre
            }
        }
    }


    static void MostrarMapa()
    {
        Console.WriteLine("Mapa de asientos:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < asientos; j++)
            {
                Console.Write(mapaAsientos[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

   
    static void ReservarAsiento()
    {
        int fila, asiento;

        Console.Write("Ingrese el número de fila (1-10): ");
        fila = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Ingrese el número de asiento (1-10): ");
        asiento = int.Parse(Console.ReadLine()) - 1;

        
        if (fila < 0 || fila >= filas || asiento < 0 || asiento >= asientos)
        {
            Console.WriteLine("Error: La fila o el asiento ingresado no es válido.");
            Console.ReadLine();
            return;
        }

        if (mapaAsientos[fila, asiento] == "L")
        {
            // Reservar el asiento
            mapaAsientos[fila, asiento] = "X"; 
            Console.WriteLine("Asiento reservado exitosamente.");
        }
        else
        {
         
            Console.WriteLine("El asiento ya está ocupado. Por favor, elija otro.");
        }

        Console.ReadLine();
    }
}
