using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    public class CLibrary
    {
        object[] List = new object[3];

        public CLibrary() { }

        public void Add(object elem)
        {
            if (List[0] == null)
            {
                List[0] = elem;
            }
            else
            {
                for (int i = List.Length; i < List.Length; i++)
                {
                    List[List.Length + 1] = elem;
                }
            }
        }

        public void Remove(object elem, int position)
        {
            
            for (int i = position; i < List.Length; i++)
            {
                List[i] = List[i + 1];
            }
        }

        public void Print()
        {
            foreach (object elem in List)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
