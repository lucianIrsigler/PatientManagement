namespace PatientManagement.Objects
{
    internal class Patient
    {
        //we use string, since string allows us to create more unique IDs
        private readonly string _patientID;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public Patient(string patientID)
        {
            _patientID = patientID;
        }

        /// <summary>
        ///     This is used when creating a patient from info retrieved from the database
        /// </summary>
        /// <param name="patientID">Patient's unique identifier</param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Patient(string patientID, string firstName, string lastName, string phoneNumber, string email)
        {
            _patientID = patientID;
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
        public Patient(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string getID()
        {
            return _patientID;
        }

        /// <summary>
        ///     Updates an attribute
        ///     0->first name
        ///     1->last name
        ///     2->phone number
        ///     3-> email
        /// </summary>
        /// <param name="attributeToChange"> </param>
        /// <param name="updatedValue"></param>
        public void updateAttribute(int attributeToChange, string updatedValue)
        {
            switch (attributeToChange)
            {
                case 0:
                    LastName = updatedValue;
                    break;
                case 1:
                    LastName = updatedValue;
                    break;
                case 2:
                    PhoneNumber = updatedValue;
                    break;
                case 3:
                    Email = updatedValue;
                    break;
                default:
                    break;
            }
        }
    }
}
