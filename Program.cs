
class Start
{
     static void Main(string[] args)
    {
        int probleNr = 1;

        switch (probleNr)
        {
            case 1:
                var p = new Problem.One.Solution();
                Console.WriteLine("Answer is: {0}", p.solve());
                break;
            default:

                break;
        }

    }
}
