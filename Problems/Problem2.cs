namespace Problem.Two {

    class Solution {       
        public string solve() {
            string amount = Console.ReadLine();
            string[] tokens = Console.ReadLine().Split();
            int sum = 0;
            foreach (var item in tokens)
            {
                sum += Int32.Parse(item);
            }
            return sum.ToString();
        }
    }
}