using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    internal class Person : PrintEdition
    {
        PrintEdition printEdition;

        public string? username;
        public Person(string? nameOfHouse, string? qualityOfBook, string? username, int countOfPage) : base(nameOfHouse, qualityOfBook, countOfPage)
        {
            this.QualityOfBook = qualityOfBook;
            this.CountOfPage = countOfPage;
            this.username = username;
            this.NameOfHouse = nameOfHouse;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
