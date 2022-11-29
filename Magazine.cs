using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    public class Magazine : Book
    {
        Book book;
        public Magazine(string? nameOfHouse, string? qualityOfBook, string? genreOfBook,int countOfPage) : base(nameOfHouse, qualityOfBook, genreOfBook,countOfPage)
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
    }
}
