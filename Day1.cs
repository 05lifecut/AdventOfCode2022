namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCalories = 0;
            int highestCalories = 0;

            string[] lines = System.IO.File.ReadAllLines("elf.txt");

            foreach (string line in lines)
            {
                if (line.Length != 0)
                {
                    int count = Convert.ToInt32(line);
                    totalCalories += count;
                    if (totalCalories > highestCalories)
                    {
                        highestCalories = totalCalories;
                    }
                }
                else if (line.Length == 0)
                {
                    totalCalories = 0;
                }
            }

            Console.WriteLine(highestCalories);
        }
    }
}

