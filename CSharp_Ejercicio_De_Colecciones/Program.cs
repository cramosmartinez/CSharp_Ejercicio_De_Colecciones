using System;
using System.Collections;
using System.Collections.Generic;

class EjerciciosColecciones
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nElige un ejercicio para ejecutar:");
            Console.WriteLine("1 - Sumar números en un ArrayList del 1 al 1000");
            Console.WriteLine("2 - Buscar un nombre en una lista");
            Console.WriteLine("3 - Sumar pares e impares de una lista de números");
            Console.WriteLine("4 - Encontrar el número mayor y menor en una lista");
            Console.WriteLine("5 - Insertar un valor en un array en una posición específica");
            Console.WriteLine("0 - Salir");
            Console.Write("Introduce el número del ejercicio: ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }
        }
    }

    static void Ejercicio1()
    {
        Console.WriteLine("\nEjercicio 1: Sumar números en un ArrayList del 1 al 1000");

        ArrayList numbers = new ArrayList();
        int sum = 0;

        for (int i = 1; i <= 1000; i++)
        {
            numbers.Add(i);
        }

        Console.WriteLine("Sumas acumulativas:");
        foreach (int number in numbers)
        {
            sum += number;
            Console.WriteLine(sum);
        }
    }

    static void Ejercicio2()
    {
        Console.WriteLine("\nEjercicio 2: Buscar un nombre en una lista");

        List<string> names = new List<string>();

        Console.WriteLine("Introduce 5 nombres:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            string name = Console.ReadLine();
            names.Add(name);
        }

        Console.Write("Introduce un nombre para buscar: ");
        string searchName = Console.ReadLine();

        if (names.Contains(searchName))
        {
            Console.WriteLine("El nombre está en la lista.");
        }
        else
        {
            Console.WriteLine("El nombre no está en la lista.");
        }
    }

    static void Ejercicio3()
    {
        Console.WriteLine("\nEjercicio 3: Sumar pares e impares de una lista de números");

        List<int> numbers = new List<int>();
        int sumEven = 0;
        int sumOdd = 0;

        Console.WriteLine("Introduce 10 números:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                sumEven += number;
            }
            else
            {
                sumOdd += number;
            }
        }

        Console.WriteLine($"Suma de números pares: {sumEven}");
        Console.WriteLine($"Suma de números impares: {sumOdd}");
    }

    static void Ejercicio4()
    {
        Console.WriteLine("\nEjercicio 4: Encontrar el número mayor y menor en una lista");

        List<int> numbers = new List<int>();

        Console.WriteLine("Introduce 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int maxNumber = numbers[0];
        int minNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
            if (number < minNumber)
            {
                minNumber = number;
            }
        }

        Console.WriteLine($"El número mayor es: {maxNumber}");
        Console.WriteLine($"El número menor es: {minNumber}");
    }

    static void Ejercicio5()
    {
        Console.WriteLine("\nEjercicio 5: Insertar un valor en un array en una posición específica");

        Console.Write("¿Cuántos elementos tendrá el array? ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduce el valor para el elemento {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Introduce un nuevo valor para insertar: ");
        int newValue = int.Parse(Console.ReadLine());

        Console.Write("Introduce la posición donde deseas insertar el nuevo valor (0 a {0}): ", n);
        int position = int.Parse(Console.ReadLine());

        if (position < 0 || position > n)
        {
            Console.WriteLine("La posición no es válida.");
            return;
        }

        int[] newArray = new int[n + 1];

        for (int i = 0, j = 0; i < newArray.Length; i++)
        {
            if (i == position)
            {
                newArray[i] = newValue;
            }
            else
            {
                newArray[i] = array[j];
                j++;
            }
        }

        Console.WriteLine("El array resultante es:");
        foreach (int value in newArray)
        {
            Console.WriteLine(value);
        }
    }
}
