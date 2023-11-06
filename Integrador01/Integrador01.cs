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
    public static void QuestionGame()
    {
      Console.WriteLine("¡Bienvenido!");
      bool gameOver = false;
      while(!gameOver)
      {
       GameOption("inicio");

      }

    }

    static void GameOption(string zona){
      switch (zona)
       {
        case "inicio":
        StartGame();
        break;
        default:
        Console.WriteLine("terminar");
        break;
       }
    }
      static void StartGame ()
      {
        string[] temas = {
        "1.Pokemon",
        "2.Programación",
        "3.Cocina",
        "4.Peliculas",
        "5.Musica",
    };
        Console.WriteLine("Seleccioná un tema");
        for(int i=0;i<temas.Length;i++)
        {
          Console.WriteLine(temas[i]);
        }
        string opcionResp = Console.ReadLine();
        Theme(opcionResp);
      }

      static void Theme(string option)
      {
        string[] preguntasPokemon = {

        }
         string[] preguntasProgramacion = {
          
        }
         string[] preguntasCocina = {
          
        }
         string[] preguntasPeliculas = {
          
        }
      
        switch (option)
        {
          case "":

          break;
          default:
          {};
          break;
        }
      }
       static void Instruction()
      {
        Console.WriteLine("elegiste la opcion 2");
      }
      static void Exit()
      {
        Console.WriteLine("salir");
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
          Instruction();
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