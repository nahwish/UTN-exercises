using System;

/*
Escribe un programa que pida al usuario un número 
y muestre en pantalla si es par o impar.

*/
class Excercise02
{
  public static void ParImpar()
  {
    int num;

    Console.WriteLine("Escriba un número");
    var isANumber = int.TryParse(Console.ReadLine(), out num);

    if (isANumber)
    {
      ValidateNum(num);
    }
    else
    {
      Console.WriteLine("No se ingresó un número válido.");
    }
  }

  public static void ValidateNum(int selectedNum)
  {
    string message;

    if (selectedNum % 2 == 0)
    {
      message = "es un número par";
    }
    else
    {
      message = "es impar";
    }
    Console.WriteLine($"{selectedNum} {message}");
  }
  //En c#, como puedo hacer para verificar si un numero es par o impar?

}