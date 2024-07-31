using assesment_2;
using assesment2;
using Roll2Dice;
using Roll5Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Menu
{
    class Game
    {
        public static void Main()

        {
            Console.WriteLine("Press 1 to select SevensOut");
            Console.WriteLine("Press 2 to check out tesitng class");
            Console.WriteLine("Press 3 to select Three or more game");
            Console.WriteLine("Press 4 to view statistics");


            Console.Write("Select");
            int option = int.Parse(Console.ReadLine());



            switch (option)
            {
                case 1:
                    SevensOut.MainSO();
                    break;

                case 2:
                    Testing.MainTest();
                    break;

                case 3:
                    ThreeOrMore.Play();
                    break;

                case 4:
                    Statistics.MainStats();
                    break;
            }
        }

    }
}