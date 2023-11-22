using System.Diagnostics.CodeAnalysis;

#pragma warning disable AreYouShure // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
var di = new DeleteInternet();
#pragma warning restore AreYouShure // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

//di.KillAll();

[Experimental("AreYouShure")]
public class DeleteInternet
{
    
    [Experimental("DontDoThis")]
    public void KillAll()
    {
        throw new NotImplementedException();
    }
}



