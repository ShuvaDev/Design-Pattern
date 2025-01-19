using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Design1
{
    public class NissanHeadLight : IHeadLight
    {
        public void CreateHeadLight()
        {
            Console.WriteLine("Nissan Headlight Created");
        }
    }
}
