using System;

class Excercise01C04
{
    public static void Inventario()
    {
        string[] array = { "laptop", "mouse", "monitor", "camara", "parlante" };
        string search = Console.ReadLine();

        int position = Array.IndexOf(array, search);

        Console.WriteLine($"La posición de {search} es {position} en el array");
    }
}
