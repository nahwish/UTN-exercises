using System;

/*
Crea un array de números enteros y verifica si está ordenado de manera ascendente
descendente o no tiene orden.
*/
class Exercise03C05
{
  public static void VerifyArrayNumbers()
  {
    Console.WriteLine("escribir numeros separados por coma: ");
    string numbers = Console.ReadLine();
    string[] arrStr = numbers.Split(',');
    string[] copia = new String[5];
    copia = arrStr;
    Array.Sort(arrStr);
    if(arrStr == copia)
    {
      Console.WriteLine("entró");
    }
  }

}