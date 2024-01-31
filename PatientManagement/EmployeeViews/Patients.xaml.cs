using PatientManagement.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PatientManagement.EmployeeViews
{
    /// <summary>
    /// Interaction logic for Patients.xaml
    /// </summary>
    public partial class Patients : Page
    {
        private PatientDatabaseHandler DatabaseHandler = new PatientDatabaseHandler();
        public Patients()
        {

            InitializeComponent();

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


        private void Search_Click(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)FindName("query");

            var data = DatabaseHandler.GetRecords("PhoneNumber", t.Text);

            DataGrid searchResults = new DataGrid();
            searchResults.IsReadOnly = true;
            searchResults.FontSize = 16;

            List<string> columnsToDisplay = new List<string> { "FirstName", "LastName", "PhoneNumber" }; // Add more columns as needed
            DataTable newDataTable = data.DefaultView.ToTable(false, columnsToDisplay.ToArray());
            // Add columns to DataGrid

            searchResults.ItemsSource = newDataTable.DefaultView;

            Grid searchGrid = (Grid)FindName("results");

            searchResults.SelectionChanged += DataGridView_SelectionChanged;


            Grid.SetRow(searchResults, 1);
            Grid.SetColumn(searchResults, 0);
            searchGrid.Children.Add(searchResults);
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            DataGrid? gv = sender as DataGrid;
            int x = gv.SelectedIndex;
            DataRowView row =  (DataRowView)gv.Items.GetItemAt(x);
            DataTable data = DatabaseHandler.GetRecords("PhoneNumber", row.Row[2].ToString());

            Label label= new Label();
            label.Content = "Patient name:";


        }
    }
}
