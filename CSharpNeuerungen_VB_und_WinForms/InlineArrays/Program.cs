var ep = new Essensplan();
ep[0] = "Salat";
ep[1] = "Gulasch";
ep[2] = "Burger";
ep[3] = "Schnitzel";
ep[4] = "Fisch";

foreach (var essen in ep)
{
    Console.WriteLine(essen);
}



[System.Runtime.CompilerServices.InlineArray(5)]
public struct Essensplan
{
    public string Essen;
}