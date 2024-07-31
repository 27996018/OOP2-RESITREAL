using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment_2
{
    public class Testing
    {
        public static void MainTest()
        {
            Random random = new Random();
            int[] dice = new int[13];

            Console.WriteLine("Press 1 then enter twice to roll the first dice");
            Console.WriteLine("Press 2 then enter twice to roll second dice");
            Console.Write("Press 3 then enter twice to roll both dice ");
            Console.WriteLine("If you get seven press any number and then enter to check if function works");
            int diceRolling = Convert.ToInt32(Console.ReadLine());
            int numberToRoll = 0;
            int option = int.Parse(Console.ReadLine());

            //for (int diceRolling = 1; diceRolling < numberToRoll; diceRolling++)

            while (diceRolling == 1)
            {

                numberToRoll++;
                int playerRandomNum;
                {
                    int firstDice = random.Next(1, 7);
                    int secondDice = random.Next(1, 7);
                    int sumOfDice;
                    switch (option)
                    {
                        case 1:

                            Console.WriteLine(firstDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;

                        case 2:
                            Console.WriteLine(secondDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;

                        case 3:
                            Console.WriteLine(sumOfDice = firstDice + secondDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;
                    }

                }
            }
            while (diceRolling == 2)
            {

                numberToRoll++;
                int playerRandomNum;
                {
                    int firstDice = random.Next(1, 7);
                    int secondDice = random.Next(1, 7);
                    int sumOfDice;
                    switch (option)
                    {
                        case 1:

                            Console.WriteLine(firstDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;

                        case 2:
                            Console.WriteLine(secondDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;

                        case 3:
                            Console.WriteLine(sumOfDice = firstDice + secondDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;
                    }

                }
            }
            while (diceRolling == 3)
            {

                numberToRoll++;
                int playerRandomNum;
                {
                    int firstDice = random.Next(1, 7);
                    int secondDice = random.Next(1, 7);
                    int sumOfDice;
                    switch (option)
                    {
                        case 1:

                            Console.WriteLine(firstDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;

                        case 2:
                            Console.WriteLine(secondDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;

                        case 3:
                            Console.WriteLine(sumOfDice = firstDice + secondDice);
                            Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i == 0; i++) ;
                            break;
                    }
                    if (firstDice + secondDice == 7)
                        break;
                }
            }
        }

    }
}

                





               