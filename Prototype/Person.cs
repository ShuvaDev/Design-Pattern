using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public Person()
        {
            Address = new Address();
        }
        public object Clone()
        {
            Person person = MemberwiseClone() as Person;

            person.Address = new Address();
            person.Address.Street = this.Address.Street;
            return person;
        }
    }
}
