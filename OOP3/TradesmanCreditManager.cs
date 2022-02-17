using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class TradesmanCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calcualted TradesmanCreditManager");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
