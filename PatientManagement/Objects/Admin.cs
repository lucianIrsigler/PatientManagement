using Microsoft.VisualBasic;
using System;

namespace PatientManagement.Objects
{
    internal class Admin
    {
        private readonly string _adminID;

        private readonly bool _isSuperAdmin;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateOnly StartingDate { get; set; }


        public Admin() { }

        public Admin(string adminID, bool isSuperAdmin, string firstName, string lastName, DateOnly startingDate)
        {
            _adminID = adminID;
            _isSuperAdmin = isSuperAdmin;
            FirstName = firstName;
            LastName = lastName;
            StartingDate = startingDate;
        }

        public string getID()
        {
            return _adminID;
        }

        public bool isSuperAdmin()
        {
            return _isSuperAdmin;
        }


    }
}
