using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanName
{
    public class Human
    {
        public string firstName;
        public string lastName;
  
        public void IntroduceMyself()
        {
            Console.WriteLine("Hello, I'm {0} {1}", firstName, lastName);


        }

    }
    
}
