using HelloWorld.Model;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PersonDetail.xaml
    /// </summary>
    public partial class PersonDetail : Window
    {
        Person person;

        public PersonDetail(Person _person)
        {
            InitializeComponent();
            person = _person;
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
        }
    }


}
