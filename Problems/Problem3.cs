namespace CodeAbbey {
    class Problem3 : IProblem{
        public string ProblemURL {get {return "https://www.codeabbey.com/index/task_view/sum-in-loop";}} 
        public string solve() {
            int amount = Int32.Parse(Console.ReadLine()!);
            string? values = null;
            string? answer = null;
            int i = 1;

            while ((values = Console.ReadLine()) != null)
            {
                int sum = 0;
                string[] numbers = values.Split();
                
                foreach (string text in numbers)
                    sum += Convert.ToInt32(text);

                answer += sum.ToString() + ' ';

                if (i >= amount)
                    break;
                i++;
            }

            return answer!;
        }
    }
}