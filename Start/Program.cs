
class Start
{
     static void Main(string[] args)
    {
        int problemNr = 2;

        switch (problemNr)
        {
            case 1:
                var problem1 = new Problem.One.Solution();
                Console.WriteLine("Answer to problem Nr {0}: {1}", problemNr.ToString(), problem1.solve());
                break;
            case 2:
                var problem2 = new Problem.Two.Solution();
                Console.WriteLine("Answer to problem Nr {0}: {1}", problemNr.ToString(), problem2.solve());
                break;
            default:
                System.Console.WriteLine("Please chose a problem.");
                break;
        }

    }
}
