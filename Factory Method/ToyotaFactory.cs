using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class ToyotaFactory : CarFactory
    {
        protected override Car MakeProduct()
        {
            Car car = new Toyota();
            return car;
        }
    }
}
