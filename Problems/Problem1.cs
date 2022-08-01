namespace CodeAbbey {
    class Problem1 : IProblem {
        public string ProblemURL {get {return "https://www.codeabbey.com/index/task_view/sum-of-two";}}
        public string solve() {
            string[] tokens = Console.ReadLine()!
                .Split(' ');
            var a = int.Parse(tokens[0]) + int.Parse(tokens[1]);
            return a.ToString();
        }
    }
}