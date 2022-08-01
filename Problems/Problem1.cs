namespace Problem.One {

    class Solution {       
        public string solve() {
            string[] tokens = Console.ReadLine()!
                .Split(' ');
            var a = int.Parse(tokens[0]) + int.Parse(tokens[1]);
            return a.ToString();
        }
    }
}