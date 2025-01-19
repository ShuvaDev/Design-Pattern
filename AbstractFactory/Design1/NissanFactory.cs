using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Design1
{
    public class NissanFactory : ICarFactory
    {
        public IEngine GetEngine()
        {
            return new NissanEngine();
        }

        public IHeadLight GetHeadLight()
        {
            return new NissanHeadLight();
        }
    }
}
