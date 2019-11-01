using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Course
    {

        public string Name { get; set; }

        public Professor Professor { get; set; }
        public int Year { get; set; }
        public Student Studente { get; set; }

        List<Student> students = new List<Student>();
        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }



        public void AfisareDetalii()
        {
            System.Console.WriteLine($"\n Detaliile Cursului: {this.Name}\n tinut de {this.Professor.Name}\n pentru anul {this.Year}\n Studentii inscrisi: ");

            foreach (var item in Students)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
