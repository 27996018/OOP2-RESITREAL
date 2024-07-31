using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment2
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        int firstDice;
        Random rnd = new Random();
        public int Value
        {
            get { return firstDice; }
            private set { firstDice = value; }
        }
        //Method
        public int Roll()
        {
            Value = rnd.Next(1, 7);
            Console.WriteLine("1,7");
            return firstDice;

        }

    }
}

