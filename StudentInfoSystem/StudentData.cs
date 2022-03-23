using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class StudentData
    {
        public static List<Student> TestStudents;

        public static void Add_TestStudents()
        {
            TestStudents = new List<Student>();
            TestStudents.Add(new Student()
            {
                Name= "Binka",
                Second_Name="Grozdanova",
                Last_Name="Aleksandrova",
                Fac_Number= "121219038",
                Specialty="FKST",
                State="редовно",
                Course="3",
                Potok="9",
                Group="30"
            });
        }


    }
}
