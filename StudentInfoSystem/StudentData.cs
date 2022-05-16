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
                Specialty = "Computer and software engineering",
                Facultet = "FCST",
                State="редовно",
                Course=3,
                Group=30,
                degree = Degree.Професионално,
                status = Education_Status.Редовен,
                stream = 9
            });
        }

        public bool IsThereStudent(string facNum)
        {
            StudentInfoContext context = new StudentInfoContext();

            Student result = context.Students.FirstOrDefault(s => s.FacultyNumber == facNum);
            return result != null;
        }
    }
}
