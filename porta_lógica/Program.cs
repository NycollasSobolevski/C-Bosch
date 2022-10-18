AndGate a = new AndGate();
// NotGate b = new NotGate();
Console.WriteLine(a.Function(true,true));



public abstract class Gate
{
    public bool inputA {get;set;}
    public bool inputB {get;set;}
    public bool Output {get;set;}

    public abstract bool Function(bool inputA, bool inputB);
    // public abstract bool Send(Gate Target);
    // public abstract bool Target(bool entrada);

}



public class AndGate : Gate
{
    public override bool Function(bool inputA,bool inputB)
    {
        return inputA && inputB;
    }

}




// public class OrGate : Gate
// {
//     public override bool Function(bool inputA,bool inputB)
//     {
//         return inputA || inputB;
//     }

// }



// public class NotGate : Gate
// {
//     public override bool Function(bool inputA,bool inputB)
//     {
//         if (inputA)
//         {
//             return false;
//         }
//         else
//         {
//             return true;
//         }
//     }

// }

