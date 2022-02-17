using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Calcualted VehicleCreditManager");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
