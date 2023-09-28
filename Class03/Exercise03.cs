using System;

/*
Escribe un programa que pida al usuario dos números 
y muestre en pantalla el mayor de ellos.

*/
class Excercise03
{
  static bool TheyAreNumbers;
  static int firstNum;
  static int secondNum;

  public static void MayorMenor()
  {
    SelecTheNumbers();
    
    if (TheyAreNumbers)
    {
      ValidateNumAndShowMessage(firstNum, secondNum);
    }
    else
    {
      Console.WriteLine("No se ingresó un número válido.");
    }
  }

  public static void ValidateNumAndShowMessage(int selectedNum1, int selectedNum2)
  {
    string message;

    if (selectedNum1 < selectedNum2)
    {
      message = $"{selectedNum2} es mayor a {selectedNum1}";
    }
    else
    {
      message = $"{selectedNum1} es mayor a {selectedNum2}";
    }
    Console.WriteLine($"{message}");
  }

  public static void SelecTheNumbers()
  {
    Console.WriteLine("Escriba el primer número");
    var firstNumberSelected = int.TryParse(Console.ReadLine(), out firstNum);

    if (firstNumberSelected)
    {

      Console.WriteLine("Escriba el segundo número");
      var secondNumberSelected = int.TryParse(Console.ReadLine(), out secondNum);

      if (secondNumberSelected) TheyAreNumbers = true;

    }
    else
    {
      TheyAreNumbers = false;
    }
  }
}