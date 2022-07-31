using Problem1;
class Start
{
     static void Main(string[] args)
    {
        Console.WriteLine("Enter 1st Number:");
        var s1 = Console.ReadLine();
        int n1 = Int32.Parse(s1);

        Console.WriteLine("Enter 2nd Number:");
        var s2 = Console.ReadLine();
        int n2 = Int32.Parse(s2);

        var p = new Solution();
        
        Console.WriteLine("Answer is: {0}", p.solve(n1, n2));
    }
}
