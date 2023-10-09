using System;
using System.Linq;//LINQ proporciona un conjunto de operadores y sintaxis especializada para consultar y manipular datos en colecciones, bases de datos, XML y otros tipos de fuentes de datos.
using System.Collections.Generic;

/*
Escribe un programa que pida al usuario 5 números 
y muestre en pantalla el mayor de ellos, el menor y el promedio.

*/

class Excercise04
{
    public static void MayorMenorYPromedio()
    {
        // Llamamos a la función SelectNumbers para que el usuario ingrese 5 números
        List<int> numbers = SelectNumbers();

        if (numbers.Count == 5)
        {
            // Usamos LINQ para encontrar el número mayor, el número menor y el promedio
            int maxNumber = numbers.Max();  
            int minNumber = numbers.Min();  
            double average = numbers.Average();  

            Console.WriteLine($"El número mayor es: {maxNumber}");
            Console.WriteLine($"El número menor es: {minNumber}");
            Console.WriteLine($"El promedio es: {average}");
        }
        else
        {
            // Si no se ingresaron 5 números, mostramos un mensaje de error
            Console.WriteLine("Debes ingresar exactamente 5 números.");
        }
    }

//Devuelve una lista de enteros escrita por el usuario
    public static List<int> SelectNumbers()
    {
        Console.WriteLine("Escribe 5 números separados por coma:");

        string input = Console.ReadLine();


        string[] numberStrings = input.Split(',');


        // Creamos una lista para almacenar los números
        List<int> numbers = new List<int>();
        // Iteramos a través de las cadenas obtenidas
        AddNumber(numberStrings,numbers);
        return numbers;
    }
// Recibe un array de numeros separados por coma y un array vacio para guardar los numeros
    public static void AddNumber(string[] numberStrings,List<int> numbers)
    {
        foreach (string numberString in numberStrings)
        {
            // Intentamos convertir cada cadena en un número entero
            if (int.TryParse(numberString, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"'{numberString}' no es un número válido y se ignorará.");
            }
        }
    }
}
