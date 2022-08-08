using CodeAbbey;
class Start
{
     static void Main(string[] args)
    {
        int problemNr = Int32.Parse(Console.ReadLine()!);
        string answer = "Nothing";

        switch (problemNr)
        {
            case 1:
                var problem1 = new Problem1();
                answer = problem1.solve();
                break;
            case 2:
                var problem2 = new Problem2();
                answer = problem2.solve();
                break;
            case 3:
                var problem3 = new Problem3();
                answer = problem3.solve();
                break;
            case 4:
                var problem4 = new Problem4();
                answer = problem4.solve();
                break;
            default:
                System.Console.WriteLine("Please chose a valid problem.");
                break;
        }


        System.Console.WriteLine("Answer to problem Nr {0}: {1}", problemNr, answer);
    }

}
