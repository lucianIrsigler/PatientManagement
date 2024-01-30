using System;
using System.Collections.Generic;
using System.Data;
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
using PatientManagement.Database;

namespace PatientManagement.EmployeeViews
{
    /// <summary>
    /// Interaction logic for EmployeeHome.xaml
    /// </summary>
    public partial class EmployeeHome : Page
    {
        private PatientDatabaseHandler PatientDatabase = new PatientDatabaseHandler();
        public EmployeeHome()
        {
            InitializeComponent();
            loadPatients();

            Button homeButton = (Button)FindName("HomeBtn");
            homeButton.Click += (s, e) =>
            {
                NavigationService.Navigate(new EmployeeHome());
            };


            Button patientButton = (Button)FindName("PatientsBtn");
            patientButton.Click += (s, e) =>
            {
                NavigationService.Navigate(new Patients());
            };


            Button doctorButton = (Button)FindName("DoctorsBtn");
            doctorButton.Click += (s, e) =>
            {
                NavigationService.Navigate(new Doctors());
            };


            Button appointmentsButton = (Button)FindName("AppointmentsBtn");
            appointmentsButton.Click += (s, e) =>
            {
                NavigationService.Navigate(new Appointments());
            };


            Button logoutButton = (Button)FindName("LogoutBtn");
            logoutButton.Click += (s, e) =>
            {
                MessageBoxResult result = MessageBox.Show("Do you want to logout",
                    "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    NavigationService.Navigate(new Login());
                }
            };
        }

        private void loadPatients()
        {
            DataGrid dataGrid = (DataGrid)FindName("patients");
            dataGrid.Columns.Clear();

            var data = PatientDatabase.GetAll();
            List<string> columnsToDisplay = new List<string> { "FirstName", "LastName", "EmailAddress" }; // Add more columns as needed
            DataTable newDataTable = data.DefaultView.ToTable(false, columnsToDisplay.ToArray());
            // Add columns to DataGrid

            dataGrid.ItemsSource = newDataTable.DefaultView;
        }
    }
}
