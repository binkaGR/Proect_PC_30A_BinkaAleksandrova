using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Second_Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OKC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void State_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Fak_number_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Course_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Group_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Potok_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Last_Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            Name.Text = student.Name;
            Second_Name.Text = student.Second_Name;
            Last_Name.Text = student.Last_Name;
            Facultet.Text = "FKST";
            OKC.Text = "бакалавър";
            Fak_number.Text = student.Fac_Number;
            Group.Text = student.Group;
            Potok.Text = student.Potok;
            Specialty.Text = student.Specialty;
            State.Text = student.State;
            Course.Text = student.Course;

        }

        private void Facultet_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Specialty_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Name.Text = "";
            Second_Name.Text = "";
            Last_Name.Text = "";
            Facultet.Text = " ";
            OKC.Text = "";
            Fak_number.Text = "";
            Group.Text = "";
            Potok.Text = "";
            Specialty.Text = "";
            State.Text = "";
            Course.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Name.IsEnabled = false;
            Second_Name.IsEnabled = false;
            Last_Name.IsEnabled = false;
            Facultet.IsEnabled = false;
            OKC.IsEnabled = false;
            Fak_number.IsEnabled = false;
            Group.IsEnabled = false;
            Potok.IsEnabled = false;
            Specialty.IsEnabled = false;
            State.IsEnabled = false;
            Course.IsEnabled = false;
        }
    }
}
