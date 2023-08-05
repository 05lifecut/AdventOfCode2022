namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("rps.txt");

            int score = 0;
            
            /*
            A & X = Rock(1)
            B & Y = Paper(2)
            C & Z = Scissors(3)
            0 for loss, 3 for draw, 6 for win
            */

            // PART 1 //
            foreach (string line in lines)
            {
                if (line == "A X")
                {
                    score += 4;
                }
                else if (line == "A Y")
                {
                    score += 8;
                }
                else if (line == "A Z")
                {
                    score += 3;
                }
                else if (line == "B X")
                {
                    score += 1;
                }
                else if (line == "B Y")
                {
                    score += 5;
                }
                else if (line == "B Z")
                {
                    score += 9;
                }
                else if (line == "C X")
                {
                    score += 7;
                }
                else if (line == "C Y")
                {
                    score += 2;
                }
                else if (line == "C Z")
                {
                    score += 6;
                }
            } 
        
            Console.WriteLine($"Original score is {score}");

            // PART 2 //
            
            /*
            A = ROCK = 1
            B = PAPER = 2
            C = SCISSORS = 3
            X = LOSE = 0
            Y = DRAW = 3
            Z = WIN = 6
            */

            int newScore = 0;

            foreach (string line in lines)
            {
                if (line == "A X")
                {
                    newScore += 3;
                }
                else if (line == "A Y")
                {
                    newScore += 4;
                }
                else if (line == "A Z")
                {
                    newScore += 8;
                }
                else if (line == "B X")
                {
                    newScore += 1;
                }
                else if (line == "B Y")
                {
                    newScore += 5;
                }
                else if (line == "B Z")
                {
                    newScore += 9;
                }
                else if (line == "C X")
                {
                    newScore += 2;
                }
                else if (line == "C Y")
                {
                    newScore += 6;
                }
                else if (line == "C Z")
                {
                    newScore += 7;
                }
            }

            Console.WriteLine($"New score is {newScore}");


        }
    }
}