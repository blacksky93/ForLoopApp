namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool answer = true;
            int number;
            while (answer != false)
            {
                Console.Write("Please enter a number:");
                string answer = Console.ReadLine();
                bool isValid = int.TryParse(, out number);
                if (isValid)
                {
                    numbers.Add(number);
                    continue;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
                
            }
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
