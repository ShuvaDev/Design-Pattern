using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Design1
{
    public interface ICarFactory
    {
        IEngine GetEngine();
        IHeadLight GetHeadLight();
    }
}
