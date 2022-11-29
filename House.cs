using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    public abstract class House
    {
        public string NameOfHouse;
        public House(string nameOfHouse)
        {
            NameOfHouse = nameOfHouse;
        }

        public override string ToString()
        {
            return NameOfHouse;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
