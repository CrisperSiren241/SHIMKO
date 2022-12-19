using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    internal class Library : CLibrary
    {
        public string AuthorName;
        public string BookName;
        public string HouseName;
        public int[] BookPrice;

        public Library(string authorName, string bookName, string houseName, int[] bookPrice)
        {
            AuthorName = authorName;
            BookName = bookName;
            HouseName = houseName;
            BookPrice = bookPrice;
        }

        public void SortJewel()
        {
            if(BookName == null)
            {
                throw new BooksException("Error");
            }
            Array.Sort(BookPrice);
        }

        public override string ToString()
        {
            string result = "";
            try
            {
                result = "Книга: " + BookName + "\nАвтор" + AuthorName + "Издательство" + HouseName + ", " + "\n" + "Цена: " + BookPrice;
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message + e.InnerException + e.Source);
            }
            return result;
        }
    }
}
