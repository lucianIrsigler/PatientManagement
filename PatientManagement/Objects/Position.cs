namespace PatientManagement.Objects
{
    internal class Position
    {

        private string positionID { get; set; }
        public string positionName { get; set; }

        private string getID()
        {
            return positionID;
        }
    }
}
