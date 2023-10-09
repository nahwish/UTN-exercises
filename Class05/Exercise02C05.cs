using System;

/*
Hacer un programa que inicialice un vector de números con valores aleatorios,
y posterior ordene los elementos de menor a mayor.
*/
class Excercise02C05
{
  public static void Order()
  {
    SortAndLogNumbers(CreateAndLogRandomNumbers());
    
  }


  public static int[] CreateAndLogRandomNumbers()
  {
    Random random = new Random();
      int[] num = new int[5];

    for (int i = 0; i < 5; i++)
    {
    int numbers = random.Next(10);
      num[i] = numbers;
      // Console.WriteLine($"Números generados aleatoreamente: {num[i]}");
    }
      Console.WriteLine($"Números generados aleatoreamente: {string.Join(",",num)}");
    return num;
  }

  public static void SortAndLogNumbers(int[] arrayNumber)
  {
    Array.Sort(arrayNumber);
  // [12,3,4,5,56]

    string stringNumbers = string.Join(",",arrayNumber);
    // Console.WriteLine($"Números ordenados: {stringNumbers}");
    Console.WriteLine($"Números ordenados: {arrayNumber}");

  }
}