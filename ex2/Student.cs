using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Student
    {
        public string Name { get; set; }

        public string Faculty { get; set; }
        public int Year { get; set; }

        public void AfisareDetalii()
        {
            System.Console.WriteLine($"Detaliile Studentului: {this.Name}, Facultatea de: {this.Faculty}, Inmaticulat in anul: {this.Year}");
        }

        public void PrintStudenti()
        {
            System.Console.WriteLine(this.Name);
        }
    }
}
