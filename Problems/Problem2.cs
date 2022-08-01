namespace CodeAbbey {
    class Problem2 : IProblem{  
        public string ProblemURL {get {return "https://www.codeabbey.com/index/task_view/sum-in-loop";}}     
        public string solve() {
            string? amount = Console.ReadLine();
            string[] tokens = Console.ReadLine()!
                .Split();
            int sum = 0;
            foreach (var item in tokens)
            {
                if (!String.IsNullOrEmpty(item))
                    sum += Int32.Parse(item);
            }
            return sum.ToString();
        }
    }
}