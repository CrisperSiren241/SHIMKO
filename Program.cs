using SHIMKO;
using System;

namespace composition 
{ 
    class Program
    {
        static void Main()
        {
            IAmPrinting obj = new IAmPrinting();
            ((IPrintEditor)obj).DoClone();
            obj.DoClone(5);
            object i = new IAmPrinting();
            (i as House).ToString();
        }
    }
}
