public class Pokemon
{
    public string Name { get; set; }
    public string Type { get; set; }


    public Pokemon(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public void ShowWeakness(bool isTrue)
    {
        string Weakness = VerifyWeakness(Type);
        if (isTrue)
        {
            Console.WriteLine($"Correcto ! ,{Name} es de tipo {Type} y es debil contra ataques de tipo {Weakness}");
        }
        else
        {
            Console.WriteLine($"oops! respuesta incorrecta; {Name} es de tipo {Type} y es debil contra ataques de tipo {Weakness}");
        }
    }

    public void Question()
    {
        Console.WriteLine($"{Name} es debil contra ataques...");
        string resp = Console.ReadLine();

        if (VerifyWeakness(Type).Contains(resp))
        {
            ShowWeakness(true);
        }
    }
    public string VerifyWeakness(string tipo)
    {

        switch (tipo)
        {
            case "Normal":
                return "Fighting";
            case "Fire":
                return "Water, Rock";
            case "Water":
                return "Electric, Grass";
            case "Electric":
                return "Ground";
            case "Grass":
                return "Fire, Ice, Poison, Flying, Bug";
            case "Ice":
                return "Fire, Fighting, Rock, Steel";
            case "Fighting":
                return "Flying, Psychic, Fairy";
            case "Poison":
                return "Ground, Psychic";
            case "Ground":
                return "Water, Ice, Grass";
            case "Flying":
                return "Electric, Ice, Rock";
            case "Psychic":
                return "Bug, Ghost, Dark";
            case "Bug":
                return "Fire, Flying, Rock";
            case "Rock":
                return "Water, Grass, Fighting, Ground, Steel";
            case "Ghost":
                return "Ghost, Dark";
            case "Dragon":
                return "Ice, Dragon, Fairy";
            case "Dark":
                return "Fighting, Bug, Fairy";
            case "Steel":
                return "Fire, Fighting, Ground";
            case "Fairy":
                return "Poison, Steel";
            default:
                return "No weakness specified";
        }

    }

}