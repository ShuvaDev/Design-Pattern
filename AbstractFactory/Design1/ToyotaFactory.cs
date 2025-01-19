using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Design1
{
    public class ToyotaFactory : ICarFactory
    {
        public IEngine GetEngine()
        {
            return new ToyotaEngine();
        }

        public IHeadLight GetHeadLight()
        {
            return new ToyotaHeadLight();
        }
    }
}
