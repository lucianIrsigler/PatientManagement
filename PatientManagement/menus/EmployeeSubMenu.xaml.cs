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
using PatientManagement.EmployeeViews;

namespace PatientManagement.menus
{
    /// <summary>
    /// Interaction logic for EmployeeSubMenu.xaml
    /// </summary>
    public partial class EmployeeSubMenu : UserControl
    {
        public EmployeeSubMenu()
        {
            InitializeComponent();
        }

        private void Navigate_Home(object sender, RoutedEventArgs e)
        {
        }

        private void Navigate_Patients(object sender, RoutedEventArgs e)
        {}

        private void Navigate_Doctors(object sender, RoutedEventArgs e)
        {}

        private void Navigate_Appointments(object sender, RoutedEventArgs e)
        {

        }

        private void Logout(object sender, RoutedEventArgs e)
        {

        }
    }
}
