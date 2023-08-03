namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCalories = 0;
            int highestCalories = 0;
            int secondCalories = 0;
            int thirdCalories = 0;

            string[] lines = System.IO.File.ReadAllLines("elf.txt");

            foreach (string line in lines)
            {
                if (line.Length != 0)
                {
                    int count = Convert.ToInt32(line);
                    totalCalories += count;
                }
                else if (line.Length == 0)
                {
                    if (totalCalories > highestCalories)
                    {
                        thirdCalories = secondCalories;
                        secondCalories = highestCalories;
                        highestCalories = totalCalories;
                        
                    }
                    else if (totalCalories > secondCalories)
                    {
                        thirdCalories = secondCalories;
                        secondCalories = totalCalories;
                    }
                    else if (totalCalories > thirdCalories)
                    {
                        thirdCalories = totalCalories;
                    }
                    totalCalories = 0;
                }
            }
            Console.WriteLine(highestCalories);
            Console.WriteLine(highestCalories + secondCalories + thirdCalories);
        }
    }
}

