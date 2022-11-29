using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    internal class TextBook : Book
    {
        Book book;
        public string Subject; 
        public TextBook(string? nameOfHouse, string? qualityOfBook, string? genreOfBook, int countOfPage, string subject) : base(nameOfHouse,qualityOfBook, genreOfBook, countOfPage)
        {
            this.QualityOfBook = qualityOfBook;
            this.CountOfPage = countOfPage;
            this.genreOfBook = genreOfBook;
            this.Subject = subject;
            this.NameOfHouse = nameOfHouse;
        }

        public override string ToString()
        {
            return NameOfHouse + QualityOfBook + CountOfPage + genreOfBook;
        }
    }
}
