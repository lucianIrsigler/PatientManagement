﻿using System;
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

namespace PatientManagement.EmployeeViews
{
    /// <summary>
    /// Interaction logic for Doctors.xaml
    /// </summary>
    public partial class Doctors : Page
    {
        public Doctors()
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
    }
}
