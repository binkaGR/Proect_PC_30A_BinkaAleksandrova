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
        public int Course { get; set; }
        public string Facultet { get; set; }
        public int Group { get; set; }
        public int stream { get; set; }
        public Degree degree { get; set; }

        public Education_Status status { get; set; }
        public byte[] Photo { get; set; }

    }
}
