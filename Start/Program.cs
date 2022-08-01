using CodeAbbey;
class Start
{
     static void Main(string[] args)
    {
        int problemNr = 4;

        switch (problemNr)
        {
            case 1:
                var problem1 = new Problem1();
                Console.WriteLine("Answer to problem Nr {0}: {1}", problemNr.ToString(), problem1.solve());
                break;
            case 2:
                var problem2 = new Problem2();
                Console.WriteLine("Answer to problem Nr {0}: {1}", problemNr.ToString(), problem2.solve());
                break;
            case 3:
                var problem3 = new Problem3();
                Console.WriteLine("Answer to problem Nr {0}: {1}", problemNr.ToString(), problem3.solve());
                break;
            case 4:
                var problem4 = new Problem4();
                Console.WriteLine("Answer to problem Nr {0}: {1}", problemNr.ToString(), problem4.solve());
                break;
            default:
                System.Console.WriteLine("Please chose a valid problem.");
                break;
        }

    }
}
