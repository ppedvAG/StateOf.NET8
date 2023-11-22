namespace Lecker;

class Programm
{
    public static void Main()
    {
        var b = new Bier("Helles");
        
        var w = new Bier("Rot");

        var s = new Schnaps("Klarer");
    }
}

//mit Primärkonstruktor
public class Bier(string name)
{
    public void ShowName()
    {
        Console.WriteLine(name);
    }
}

//mit klassischem Konstruktor
public class Wein
{
    private string name;

    public Wein(string name)
    {
        this.name = name;
    }

    public void ShowName()
    {
        Console.WriteLine(name);
    }
}

record Schnaps(string Name);

