using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Roll5Dice
{
    public class ThreeOrMore
    {

        static public void Play()
        {
            Random random = new Random();
            int[] dice = new int[30];

            Console.WriteLine("Press 1 to roll all five dice");
            int diceRolling = Convert.ToInt32(Console.ReadLine());
            int numberToRoll = 1;

            while (diceRolling == 1)
            {
                //for (int diceRolling = 1; diceRolling < numberToRoll; diceRolling++)
                {
                    numberToRoll++;
                    int playerRandomNum;
                    int enemyRandomNum;
                    int playerPoints = 1;
                    int enemyPoints = 1;

                    for (int i = 0; i == dice.Length; i++)
                    {
                        Console.WriteLine($"{i} {dice[i]}");
                    }
                    for (int i = 0; i == 0; i++)
                    {
                        playerRandomNum = random.Next(1, 7);
                        Console.WriteLine("You rolled " + playerRandomNum);
                        Console.WriteLine("...");
                        int Dice1 = random.Next(1, 7);
                        int Dice2 = random.Next(1, 7);
                        int Dice3 = random.Next(1, 7);
                        int Dice4 = random.Next(1, 7);
                        int Dice5 = random.Next(1, 7);

                        if (Dice1 == Dice2 & Dice2 == Dice3 & Dice3 == Dice4 & Dice4 == Dice5) ;
                        Console.WriteLine("You have got 5 of a kind! You scored 12 points!:D");
                        if (Dice1 == Dice2 & Dice2 == Dice3) ;
                        Console.WriteLine("You have got 3 of a kind! You scored 3 point!!!");
                        if (Dice3 == Dice4 & Dice4 == Dice5) ;
                        Console.WriteLine("Three of a kind? That's a good 3 points");
                        if (Dice1 == Dice2) ;
                        Console.WriteLine("That's two of a kind, but not enought to get points :( rethrow and hope for a better luck");
                        if (Dice2 == Dice3) ;
                        Console.WriteLine("Two of a kind, maybe no points this time, but you can rehtrow");
                        if (Dice3 == Dice4) ;
                        Console.WriteLine("Two of a kind, well, two equal values but that won't get you a point rethrow however might!");
                        if (Dice4 == Dice5) ;
                        Console.WriteLine("Two of a kind, what a result, still not high enough for points, rethrow it again to get points now");
                        if (Dice1 == Dice2 & Dice2 == Dice3 & Dice3 == Dice4) ;
                        Console.WriteLine("Four of a kind, that was amazing, you have 6 points!");
                        if (Dice4 == Dice5 & Dice5 == Dice3 & Dice3 == Dice2) ;
                        Console.WriteLine("That's four of a kind! 6 points are yours now!");
                        System.Threading.Thread.Sleep(1000);
                        

                        enemyRandomNum = random.Next(0, 7);
                        Console.WriteLine("Enemy AI rolled " + enemyRandomNum);
                        Console.WriteLine("...");
                        if (Dice1 == Dice2 & Dice2 == Dice3 & Dice3 == Dice4 & Dice4 == Dice5) ;
                        Console.WriteLine("Enemy AI has got 5 of a kind! It scores 12 points!:D");
                        if (Dice1 == Dice2 & Dice2 == Dice3) ;
                        Console.WriteLine("Enemy AI has got 3 of a kind! It scores 3 points!!!");
                        if (Dice3 == Dice4 & Dice4 == Dice5) ;
                        Console.WriteLine("Three of a kind? That's a good 3 points");
                        if (Dice1 == Dice2) ;
                        Console.WriteLine("That's two of a kind, but not enought to get points, enemy AI will still rethrow and try again");
                        if (Dice2 == Dice3) ;
                        Console.WriteLine("Two of a kind, maybe no points this time, but Enemy AI can rehtrow");
                        if (Dice3 == Dice4) ;
                        Console.WriteLine("Two of a kind, well, two equal values but that won't get Enemy AI a point rethrow however might!");
                        if (Dice4 == Dice5) ;
                        Console.WriteLine("Two of a kind, what a result, still not high enough for points, Enemy AI will still rethrow it again to get points");
                        if (Dice1 == Dice2 & Dice2 == Dice3 & Dice3 == Dice4) ;
                        Console.WriteLine("Four of a kind, that was scarry, enemy AI just scored 6 points!");
                        if (Dice4 == Dice5 & Dice5 == Dice3 & Dice3 == Dice2) ;
                        Console.WriteLine("That's four of a kind! Enemy AI has 6 points now!");
                    }
                }
            }
        }
    }
}

