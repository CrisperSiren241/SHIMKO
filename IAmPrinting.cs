using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    public class IAmPrinting : IPrintEditor
    {
        public void DoClone(int i) { }
        void  IPrintEditor.DoClone() { }
    }
}
