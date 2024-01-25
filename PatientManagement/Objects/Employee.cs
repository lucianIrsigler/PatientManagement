
namespace PatientManagement
{
    internal class Employee
    {
        //we use string, since string allows us to create more unique IDs
        private readonly string _employeeID;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public Employee(string employeeID)
        {
            _employeeID = employeeID;
        }

        /// <summary>
        ///     This is used when creating a patient from info retrieved from the database
        /// </summary>
        /// <param name="patientID">Patient's unique identifier</param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Employee(string employeeID, string firstName, string lastName, string phoneNumber, string email)
        {
            _employeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        ///     Used to create a new Patient
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Employee(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string getID()
        {
            return _employeeID;
        }

    }
}
