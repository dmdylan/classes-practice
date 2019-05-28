using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanNameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Human dylan = new Human();
            Human trevor = new Human();

            dylan.firstName = "Dylan";
            dylan.lastName = "Danowski";
            trevor.firstName = "Trevor";
            trevor.lastName = "Danowski";

            dylan.IntroduceMyself();
            trevor.IntroduceMyself();


            Console.ReadLine();

        }
    }
}
