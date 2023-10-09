using System;
using System.Linq;

/*
Se quiere realizar un programa que lea por teclado las 5 notas obtenidas por un alumno 
(comprendidas entre 0 y 10).
A continuación debe mostrar todas las notas, la nota media, la nota más alta que ha sacado y la menor.
*/
class Excercise01C05
{

  public static void Notes()
  {
    List<string> numberStrings;
    List<int> numbers = new List<int>();

    do
    {
      Console.WriteLine("Escribe 5 números (del 0 al 10) separados por coma:");
      numberStrings = ValidateNumbres();
    } while (numberStrings == null);

    AddNumbresToList(numbers, numberStrings);
    ShowMessage(numbers);
  }

  public static List<string> ValidateNumbres()
  {
    string input = Console.ReadLine();
    List<string> listOfNumbers = input.Split(',').ToList();

    if (listOfNumbers.Count != 5)
    {
      Console.WriteLine("Entrada no válida. Por favor, ingrese 5 números separados por comas.");
      return null; 
    }

    return listOfNumbers;
  }

  public static void AddNumbresToList(List<int> numbers, List<String> numberStrings)
  {
    foreach (string numberString in numberStrings)
    {

      int number = int.Parse(numberString);
      if (number >= 0 && number <= 10)
      {
        numbers.Add(number);
      }
      else
      {
        Console.WriteLine("Los numeros ingresados deben ser del 0 al 10, intentar nuevamente...");
        Notes();
        return;
      }
    }
  }

  public static void ShowMessage(List<int> numbers)
  {
    int menor = numbers.Min();
    int mayor = numbers.Max();
    double notaMedia = numbers.Average();

    Console.WriteLine("El menor número es: " + menor);
    Console.WriteLine("El mayor número es: " + mayor);
    Console.WriteLine("La nota media es: " + notaMedia);
  }
}
