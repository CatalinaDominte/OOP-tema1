using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Professor
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }

        public void AfisareDetalii()
        {
            System.Console.WriteLine($"Detaliile Profesorului: {Name}, Facultatea: {Faculty}, Specializarea: {Specialization}");
        }
    }
}
