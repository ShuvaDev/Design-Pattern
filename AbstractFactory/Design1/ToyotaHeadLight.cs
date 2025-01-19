using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Design1
{
    public class ToyotaHeadLight : IHeadLight
    {
        public void CreateHeadLight()
        {
            Console.WriteLine("Toyota Headlight Created");
        }
    }
}
