using System.Runtime.InteropServices;

class Integers
{
    [DllImport("hallo", EntryPoint = "addition")]
    public static extern uint Addition(uint a, uint b);

    static public void Main()
    {
        var sum = Integers.Addition(1, 2);
        Console.WriteLine(sum);
    }
}