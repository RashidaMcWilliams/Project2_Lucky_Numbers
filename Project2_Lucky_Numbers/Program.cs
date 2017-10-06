using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain;
            do
            {
                Console.WriteLine("Welcome to Lucky Numbers!");
                Console.WriteLine("You can win up to $75,000 in cash and prizes.");
                Console.WriteLine("Please enter your name to get started.");
                string userName = Console.ReadLine().ToUpper();

                Console.WriteLine("Welcome, " + userName);
                Console.WriteLine("The game is very simple.");
                Console.WriteLine("Select six numbers.");
                Console.WriteLine("If you match the LUCKY NUMBERS, you win!");
                Console.WriteLine("Let's get started. Give me a low number.");
                int lowNum = int.Parse(Console.ReadLine());
                if (lowNum < 0 || lowNum > 10)
                {
                    Console.WriteLine("Invalid number. Please guess again.");
                    lowNum = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine();
                }

                Console.WriteLine("Great! Now give me a high number.");
                int highNum = int.Parse(Console.ReadLine());
                if (highNum < 0 || highNum < 15 || highNum > 50)
                {
                    Console.WriteLine("Invalid number. Please guess again.");
                    highNum = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine();
                }

                Console.WriteLine("Awesome! Let's begin.");
                Console.WriteLine("Please enter six numbers between " + lowNum + " and " + highNum);


                int[] userNumbers = new int[6];

                for (int i = 0; i < userNumbers.Length; i++)
                {
                    userNumbers[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Great job! Your number is: " + userNumbers[i]);
                    Console.WriteLine("Enter your next number.");
                    while (i > 5)


                    {
                        Console.WriteLine();
                    }

                }

                Console.WriteLine();

                Random rando = new Random();
                int[] luckyNumbers = new int[6];
                for (int n = 0; n < luckyNumbers.Length; n++)
                {
                    luckyNumbers[n] = rando.Next(lowNum, highNum);
                    Console.WriteLine("Lucky number: " + luckyNumbers[n]);
                }

                int matchNum = 0;

                for (int i = 0; i < userNumbers.Length; i++)
                {
                    for (int j = 0; j < luckyNumbers.Length; j++)
                    {
                        if (userNumbers[i] == luckyNumbers[j])
                        {
                            matchNum++;

                        }
                    }
                }
                Console.WriteLine("You've got " + matchNum + " matches!");

                double sum = matchNum * .16;
                double totalWinnings = sum * 75000;
                Console.WriteLine("You win $" + totalWinnings);



                Console.WriteLine("Would you like to play Lucky Numbers again? (YES/NO)");
                playAgain = Console.ReadLine().ToUpper();

            }
            while (playAgain == "YES");
            Console.WriteLine("One more time!");

        }
    }
}






            //int userNum1 = int.Parse(Console.ReadLine());
            //if (userNum1 < 0 || userNum1 > 15)
            //{
            //    Console.WriteLine("Invalid number. Please guess again.");
            //    userNum1 = int.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Great! Now let's choose your second number. Pick one between 45 and 60.");
            //int userNum2 = int.Parse(Console.ReadLine());
            //if (userNum2 < 45 || userNum2 > 60)
            //{
            //    Console.WriteLine("Invalid number. Please guess again.");
            //    userNum2 = int.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Awesome! Let's get your third number. Anything between 1 and 61.");
            //int userNum3 = int.Parse(Console.ReadLine());
            //if (userNum3 < 0 || userNum3 > 60)
            //{
            //    Console.WriteLine("Invalid number. Please guess again.");
            //    userNum3 = int.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Fourth number, please.");
            //int userNum4 = int.Parse(Console.ReadLine());
            //if (userNum4 < 0 || userNum4 > 60)
            //{
            //    Console.WriteLine("Invalid number. Please guess again.");
            //    userNum4 = int.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Fifth number. Hit me!");
            //int userNum5 = int.Parse(Console.ReadLine());
            //if (userNum5 < 0 || userNum5 > 60)
            //{
            //    Console.WriteLine("Invalid number. Please guess again.");
            //    userNum5 = int.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Let's finish up strong. Sixth number.");
            //int userNum6 = int.Parse(Console.ReadLine());
            //if (userNum6 < 0 || userNum6 > 60)
            //{
            //    Console.WriteLine("Invalid number. Please guess again.");
            //    userNum6 = int.Parse(Console.ReadLine());
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            //int[] userNumbers = new int[6];
            //userNumbers[0] = userNum1;
            //userNumbers[1] = userNum2;
            //userNumbers[2] = userNum3;
            //userNumbers[3] = userNum4;
            //userNumbers[4] = userNum5;
            //userNumbers[5] = userNum6;

            //for (int i = 0; i <userNumbers.Length; i++)
            //{
            //    userNumbers[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Great job! Your numbers are:");
            //    Console.WriteLine("Lucky number: " + userNumbers[i]);

            //}

            //Console.WriteLine("Great job! Your numbers are:");
            //Console.Write("Lucky number: " + userNumbers[0]);
            //Console.Write("Lucky number: " + userNumbers[1]);
            //Console.Write("Lucky number: " + userNumbers[2]);
            //Console.Write("Lucky number: " + userNumbers[3]);
            //Console.Write("Lucky number: " + userNumbers[4]);
            //Console.Write("Lucky number: " + userNumbers[5]);




            //string[4] uNums = int.Parse(Console.ReadLine());
            //uNums[0] = userNum3;
            //uNums[1] = userNum4;
            //uNums[2] = userNum5;
            //uNums[3] = userNum6;







            //Random rando = new Random();
            //int firstNum = rando.Next(1, 16);
            //int secondNum = rando.Next(45, 61);
            //int thirdNum = rando.Next(1, 61);
            //int fourthNum = rando.Next(1, 61);
            //int fifthNum = rando.Next(1, 61);
            //int sixthNum = rando.Next(1, 61);


            //int[] luckyNumbers = new int[6];
            //luckyNumbers[0] = firstNum;
            //luckyNumbers[1] = secondNum;
            //luckyNumbers[2] = thirdNum;
            //luckyNumbers[3] = fourthNum;
            //luckyNumbers[4] = fifthNum;
            //luckyNumbers[5] = sixthNum;

            //for (int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    luckyNumbers[i] = int.Parse(Random());
            //}

            //Console.WriteLine("The lucky numbers are: ");
            //Console.WriteLine("Lucky number: " + luckyNumbers[0]);
            //Console.WriteLine("Lucky number: " + luckyNumbers[1]);
            //Console.WriteLine("Lucky number: " + luckyNumbers[2]);
            //Console.WriteLine("Lucky number: " + luckyNumbers[3]);
            //Console.WriteLine("Lucky number: " + luckyNumbers[4]);
            //Console.WriteLine("Lucky number: " + luckyNumbers[5]);





            //Console.WriteLine("Would you like to play Luck Numbers again? (YES/NO)");
            //string playAgain = Console.ReadLine();

            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("One more time!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            //Random rando = new Random();
            //Inclusive of first number but exclusive of second number
            //Console.WriteLine(rando.Next(5, 15));

            //int firstNum = rando.Next(5, 15);
            //int secondNum = rando.Next(5, 15);

            //while (firstNum == secondNum)
            //{
            //    secondNum = rando.Next(5, 15);
       
    
    

