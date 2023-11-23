using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


/*
Ejercicio 1:
Crearemos un pequeño juego de aventura de texto, en el cual cada una de las situaciones que atraviese el jugador serán contempladas por funciones.
Tendremos también una o más funciones que administren el inventario (el cual será un array).
Utilice su imaginación y los conceptos vistos hasta ahora (Tipos de datos, condicionales, bucles y funciones), no es necesario que sea un juego elaborado ni complejo, simplemente que funcione y aplique los temas vistos.

*/
class Integrador01
{
  public static bool gameOver = false;
  public static string state = "inicio";
  public static void QuestionGame()
  {
    Console.WriteLine("¡Bienvenido!");

    // bool gameOver = false;

    while (!gameOver)
    {
      switch (state)
      {
        case "inicio":
          StartGame();
          break;
        case "Select":
        
        break;
        case "Salir":
          Exit();
          break;
        default:
          break;
      }

    }


  }



    

  
  static void StartGame()
  {
    string[] temas = {
        "1.Pokedex",
        "2.Como usarlo",
        "3.Salir",

    };
    Console.WriteLine("Seleccioná una opción");
    for (int i = 0; i < temas.Length; i++)
    {
      Console.WriteLine(temas[i]);
    }
    string opcionResp = Console.ReadLine();
    Option(opcionResp);
  }

  static void Option(string option)
  {


    switch (option)
    {
      case "1":
        Pokedex();
        break;
      case "3":
        Exit();
        break;
      default:
        { };
        break;
    }
  }
  static void Pokedex()
  {
    for (int i = 0; i < 151; i++)
    {
      Console.WriteLine($"{i + 1}. {PokeName.pokename[i]}");
    }

  }
  static void Exit()
  {
    Console.WriteLine("Hasta la proxima!");
    gameOver = true;
  }

  static void Init()
  {
    Console.WriteLine("1. Jugar");
    Console.WriteLine("2. ¿Cómo se juega?");
    Console.WriteLine("3. salir");

    string option = Console.ReadLine();

    switch (option)
    {
      case "1":
        StartGame();
        break;
      case "2":
        Pokedex();
        break;
      case "3":
        Exit();
        break;
      default:
        Console.WriteLine("Opción no valida");
        break;
    }
  }

}
