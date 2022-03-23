using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;
namespace StudentInfoSystem
{
    class StudentValidation
    {

        public static Student GetStudentDataByUser(User user)
        {
            Student student = new Student();

            if (user.FakNum!=student.Fac_Number)
                {
                Console.Write( "Няма студент със този факултетен номер!");
                    student=null;
                 }
            if (user.FakNum == null)
                {
                Console.Write("Не е подаден фькултетен номер! ");
                student = null;
            }
                return student;
        }
      }
}
