using System;
/*
Dados dos lados de un triángulo, calcular la hipotenusa mediante Pitágoras.
*/
class Exercise16C02
{
  public static void triangle()
  {
    double catetoA = 3;
    double catetoO = 4;
    double hipotenusa;

    hipotenusa = Math.Pow(catetoA,2) + Math.Pow(catetoO,2);
    Console.WriteLine(Math.Sqrt(hipotenusa));

  }

}