using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    class LibraryException : NullReferenceException
    {
        public LibraryException(string Emessage) : base(Emessage) { }
    }
}
