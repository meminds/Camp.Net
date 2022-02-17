using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class MyDictionary<nT,aT>
    {

        nT[] names;
        aT[] ages;
        nT[] tempNames;
        aT[] tempAges;

        public MyDictionary()
        {
            names = new nT[0];
            ages = new aT[0];
        }

        public int Count()
        {
            return names.Length;
        }

        public void Add(nT name, aT age)
        {
            tempNames = names;

            names = new nT[names.Length + 1];

            for (int i = 0; i < tempNames.Length; i++)
            {
                names[i] = tempNames[i];
            }
            names[names.Length - 1] = name;

            tempAges = ages;

            ages = new aT[ages.Length + 1];

            for (int j = 0; j < tempAges.Length; j++)
            {
                ages[j] = tempAges[j];
            }

            ages[ages.Length - 1] = age;

            Console.WriteLine(name + " " + age);
        }
    }
}
