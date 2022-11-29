using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIMKO
{
    public class PrintEdition : House
    {
        public string? QualityOfBook;
        public int CountOfPage;

        public PrintEdition(string? nameOfHouse, string? qualityOfBook, int countOage) : base(nameOfHouse)
        {
            QualityOfBook = qualityOfBook;
            CountOfPage = countOage;
            nameOfHouse = nameOfHouse;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
