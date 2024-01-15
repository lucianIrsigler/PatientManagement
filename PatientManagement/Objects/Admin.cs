namespace PatientManagement.Objects
{
    internal class Admin
    {
        private readonly string _adminID;

        private readonly bool _isSuperAdmin;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Admin() { }

        private string getID()
        {
            return _adminID;
        }


    }
}
