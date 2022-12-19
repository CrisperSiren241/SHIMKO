using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    class BooksException : ArgumentException
    {
        public BooksException(string Emessage) : base(Emessage) { }
    }
}
