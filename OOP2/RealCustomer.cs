using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Individual bireysel müsterinin ingsi
    class RealCustomer : Customer
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
