using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Student
    {
        public string Name { get;set;}
        public string Second_Name { get; set; }
        public string Last_Name { get; set; }
        public string Fac_Number { get; set; }
        public string Specialty { get; set; }
        public string State { get; set; }
        public string Course { get; set; }
        public string Potok { get; set; }
        public string Group { get; set; }
        public Student()
        {
            this.Name = "Binka";
            this.Second_Name ="Grozdanova";
            this.Last_Name = "Aleksandrova";
            this.Fac_Number = "121219038";
            this.Specialty = "KSI";
            this.State = "редовно";
            this.Course = "3";
            this.Potok = "9";
            this.Group = "29";
        }
    }
}
