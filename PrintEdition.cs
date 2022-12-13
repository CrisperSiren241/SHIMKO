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
    enum Print
    {
        Company, Action, Corporate
    }

    struct StructPrintEdition
    {
        public string information;
        public int year;
        Print etype;
        public void PrintEType()
        {
            etype = Print.Action;
        }

        public void Info()
        {
            Console.WriteLine("Использован метод структуры!");
            Console.WriteLine(information);
            Console.WriteLine(year);
        }
    }
}
