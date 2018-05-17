using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Human : IHuman,IB
    {
        // Class 1 - 1 Class
        // Class 1 - n Interface
        public void Action1()
        {
            Console.WriteLine("Action 1");
        }

        public void Action2()
        {
            Console.WriteLine("Action 2");
        }

        public void B1()
        {
            Console.WriteLine("B 1");
        }

        public void B2()
        {
            Console.WriteLine("B 2");
        }
    }
}
