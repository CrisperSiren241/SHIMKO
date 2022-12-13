using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    public class Book : PrintEdition
    {
        PrintEdition PrintEdition;
        public string genreOfBook;
        public Book(string? nameOfHouse, string? qualityOfBook, string? genreOfBook,int countOfPage) : base(nameOfHouse,qualityOfBook, countOfPage)
        {
            this.QualityOfBook = qualityOfBook;
            this.CountOfPage = countOfPage;
            this.genreOfBook = genreOfBook;
            this.NameOfHouse = nameOfHouse;
        }

        public override string ToString()
        {
            return NameOfHouse + QualityOfBook + CountOfPage + genreOfBook;
        }

        enum EBook
        {
            Popular, cheap, expensive
        }

        struct StructBook
        {
            EBook etype;
            public void PrintEType()
            {
                etype = EBook.expensive;
            }

        }
    }
}
