using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roll2Dice
{
    internal class SevensOut


    {
        public static void MainSO()

        {
            Random random = new Random();
            int[] dice = new int[13];



            int totalRollDice = 0;
            int enemytotalScore = 0;


            //int numberToRoll = 1;


            Console.WriteLine("Press 1 and then enter to roll the dice");
            int diceRolling = Convert.ToInt32(Console.ReadLine());
            int numberToRoll = 0;
            //for (int diceRolling = 1; diceRolling < numberToRoll; diceRolling++)

            while (diceRolling == 1)
            {
                numberToRoll++;
                int playerRandomNum;
                int enemyRandomNum;

                {

                    int firstDice = random.Next(1, 7);
                    int secondDice = random.Next(1, 7);
                    int sumOfDice = firstDice + secondDice;
                    

                    {
                        if (firstDice == secondDice)
                            sumOfDice = 2 * (firstDice + secondDice);
                        else
                            sumOfDice = firstDice + secondDice;
                    }
                    totalRollDice = totalRollDice + sumOfDice;

                    for (int i = 0; i == dice.Length; i++)
                    {
                        Console.WriteLine($"{i} {dice[i]}");
                    }

                    
                  //player turn  

                    for (int i = 0; i == 0; i++) ;
                    {
                        playerRandomNum = random.Next(1, 7);                        
                        Console.WriteLine("You rolled");
                        Console.WriteLine(sumOfDice);
                        Console.WriteLine(totalRollDice);
                        System.Threading.Thread.Sleep(1000);
                        if (firstDice + secondDice == 7)
                            break;
                        

                        firstDice = random.Next(1, 7);
                        secondDice = random.Next(1, 7);

                        sumOfDice = firstDice + secondDice;

                        enemytotalScore = enemytotalScore + sumOfDice;
                        
                       
                        //enemy turn

                        for (int i = 0; i == 0; i++) ;
                        {
                            enemyRandomNum = random.Next(1, 7);                         
                            Console.WriteLine("Enemy rolled");
                            Console.WriteLine(sumOfDice);
                            Console.WriteLine(enemytotalScore);
                            System.Threading.Thread.Sleep(1000);
                        }
                        if (firstDice + secondDice == 7)
                            break;     
                        
                        firstDice = random.Next(1, 7);
                        secondDice = random.Next(1, 7);

                        sumOfDice = firstDice + secondDice;


                        Console.WriteLine("Press 1 and then enter to roll the dice?");
                        numberToRoll = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i == 0; i++) ;
                    }



                }
            }
        }
    }
}




















