using System;

/*
Escribe un programa que pida al usuario
un número y muestre en pantalla si es positivo o negativo.
*/
class Excercise01
{
    public static void MostrarMensaje()
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

        if (selectedNum > 0)
        {
            message = "es positivo";
        }
        else if (selectedNum == 0)
        {
            message = "no es positivo, tampoco negativo";
        }
        else
        {
            message = "es negativo";
        }
        Console.WriteLine($"{selectedNum} {message}");
    }



}
