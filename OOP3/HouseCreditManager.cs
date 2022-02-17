using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class HouseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calcualted HouseCreditManager");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
