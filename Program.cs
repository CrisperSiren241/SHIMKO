using SHIMKO;
using System;

namespace composition 
{ 
    class Program
    {
        static void Main()
        {
            try
            {
                IAmPrinting obj = new IAmPrinting();
                ((IPrintEditor)obj).DoClone();
                obj.DoClone(5);
                object i = new IAmPrinting();
                (i as House).ToString();
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Source + e.Message);
            }
            catch(BooksException e)
            {
                Console.WriteLine(e.InnerException);
            }
            finally
            {
                Console.WriteLine("Used Finally Block");
            }
        }
    }
}
