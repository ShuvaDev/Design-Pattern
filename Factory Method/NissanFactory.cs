using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class NissanFactory : CarFactory
    {
        protected override Car MakeProduct()
        {
            Car car = new Nissan("N103", 13094);
            return car;
        }
    }
}
