namespace CodeAbbey {
    class Problem4 : IProblem {
        public string ProblemURL {get {return "https://www.codeabbey.com/index/task_view/min-of-two";}}
        public string solve() {
            string answer = "";
            int amount = Int32.Parse(Console.ReadLine()!);
            string? values = "";
            int i = 1;
            
            while ((values = Console.ReadLine()) != null)
            {
                string[] numbers = values.Split();

                if (Int32.Parse(numbers[0]) > Int32.Parse(numbers[1]))
                    answer += numbers[1];
                else
                    answer += numbers[0];

                answer += ' ';
                if (i >= amount)
                    break;
                i++;    
            }
            return answer;
        }
    }
}