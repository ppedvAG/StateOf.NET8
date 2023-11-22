using System.Runtime.CompilerServices;

// namespace HalloInterceptors;

Console.WriteLine("Hello Interceptors!");

public static class Interception
{

    //[InterceptsLocation("Program.cs", line: 44, character: 4)]
    public static void TrenneUns(this NichtsKannUnsTrennen nkut)
    {
        Console.Write("🤮");
    }
}

public class NichtsKannUnsTrennen
{
    public NichtsKannUnsTrennen()
    {
        Console.WriteLine("🍺🍷");
    }
}

