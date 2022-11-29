using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    internal class Author : Person
    {
        Person person;
        string? NameOfAuthor;
        public Author(string? nameOfHouse, string? qualityOfBook, string? username, string? NameOfAuthor, int countOfPage) : base(nameOfHouse,qualityOfBook, username, countOfPage)
        {
            this.QualityOfBook = qualityOfBook;
            this.CountOfPage = countOfPage;
            this.username = username;
            this.NameOfAuthor = NameOfAuthor;
            this.NameOfHouse = nameOfHouse;
        }

        public override string ToString()
        {
            return NameOfAuthor;
        }
    }
}
