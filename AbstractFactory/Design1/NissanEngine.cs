using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Design1
{
    public class NissanEngine : IEngine
    {
        public void CreateEngine()
        {
            Console.WriteLine("Nissan Engine Created");
        }
    }
}
