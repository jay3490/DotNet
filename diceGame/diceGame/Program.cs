namespace Dice_Game
{
    class Program 
    {
        static void Main(string[] args)
        {
            //players 
            int playerRandomNum;
            int enemyRandomNum;

            //score or points
            int playerScore = 0;
            int enemyScore = 0;    

            //random object for generating random number
            var random = new Random();
            
            Console.WriteLine("****** Welcome To the Dice Game ******");
            Console.WriteLine();

            //loop for rolling dice
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press any key to Roll the Dice! {0} Are Rounds left.", 3 - i);
                Console.WriteLine("--------------------------------------------------");
                
                Console.ReadKey();

                playerRandomNum = random.Next(1,7); 
                Console.WriteLine("# You rolled a: " + playerRandomNum);

                Console.WriteLine("Please wait Enemy is Rolling Dice!");
                System.Threading.Thread.Sleep(1000);    
                
                enemyRandomNum = random.Next(1,7);
                Console.WriteLine("# Enemy AI rolled: " + enemyRandomNum);

                if (playerRandomNum < enemyRandomNum)
                {
                    enemyScore++;
                    Console.WriteLine();
                    Console.WriteLine("*** Enemy Won, You Lose ***");
                }
                else if (playerRandomNum > enemyRandomNum)
                {
                    playerScore++;
                    Console.WriteLine();
                    Console.WriteLine("*** You Won, Enemy Lose ***");
                }
                else if (playerRandomNum == enemyRandomNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** It's a Tie ***");
                }
                else 
                {
                    Console.WriteLine();
                    Console.WriteLine("*** please start a new game ***");
                }

            }

            //score counting
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("The Scores are Player: {0} and Enemy: {1} !!!", playerScore, enemyScore);
            Console.WriteLine("--------------------------------------------------");

            //results
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            if (playerScore < enemyScore)
                Console.WriteLine("ENEMY IS THE WINNER WITH SCORE {0}, CONGRATULATIONS !!!", enemyScore);
            else if (playerScore > enemyScore)
                Console.WriteLine("PLAYER IS THE WINNER WITH SCORE {0}, CONGRATULATIONS !!!", playerScore);
            else
                Console.WriteLine("IT'S A DRAW");
            Console.WriteLine("--------------------------------------------------------");

        }
    }
}