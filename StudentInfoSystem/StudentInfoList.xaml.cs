using StudentInfoSystem.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for StudentInfoList.xaml
    /// </summary>
    public partial class StudentInfoList : Window
    {

          private StudentInfoContext context;

        public List<Student> Student  = new List<Student>();

        public StudentInfoList()
        {
            InitializeComponent();
            context = new StudentInfoContext();
            DataContext = this;
            Student = GetActiveStudents();
        }

        private List<Student> GetActiveStudents()
        {
            return context.Students
                .ToList()
                .Where(s => s.Status == Education_Status.Редовен || s.Status == Education_Status.Задочен)
                .OrderBy(s => s.FirstName)
                .ThenByDescending(s => s.Course)
                .ThenBy(s => s.LastName)
                .Select(s => new Student()
                {
                    Name = s.First_Name,
                    Second_Name = s.Second_Name,
                    Last_Name = s.Last_Name,
                    Specialty = s.Specialty,
                    Fac_Number = s.Fac_Number,
                    Course = s.course,
                    status = s.status
                })
                .ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    }

