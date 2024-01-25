using PatientManagement.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement
{
    internal class Consultation
    {

        private readonly string _consultationID;
        private Patient? _patient;
        private Employee? _employee;
        public DateTime? ConsultationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getID()
        {
            return _consultationID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consultationID"></param>
        /// <param name="patient"></param>
        /// <param name="employee"></param>
        /// <param name="consultationDate"></param>
        public Consultation(string consultationID, Patient patient, Employee employee, DateTime consultationDate)
        {
            _consultationID = consultationID;
            _patient = patient;
            _employee = employee;
            ConsultationDate = consultationDate;
        }

        /// <summary>
        /// 
        /// </summary>
        public Consultation()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consultationDate"></param>
        public Consultation(DateTime consultationDate)
        { }

        /// <summary>
        /// Adds the consultation to the database
        /// </summary>
        public void BookConsultation()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consultationDate"></param>
        public void EditConsultationDate(DateTime consultationDate)
        {
            ConsultationDate = consultationDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newPatient"></param>
        public void ChangePatient(Patient newPatient)
        {
            _patient = newPatient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newEmployee"></param>
        public void ChangeEmployee(Employee newEmployee)
        {
            _employee = newEmployee;
        }

        /// <summary>
        /// Removes the consultation from the database
        /// </summary>
        public void CancelConsultation()
        {

        }

    }
}
