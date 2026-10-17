using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    internal class Patient : Person
    {
        

        public int PatientID { get; set; }
        public List<string> MedicalHistory { get; set; }


        public Patient(string name, int age, long nationalID, int patientID) : base(name, age, nationalID)
        {
            PatientID = patientID;
            MedicalHistory = new List<string>();
        }

        public void AddToMedicalHistory(string disease)
        {
            MedicalHistory.Add(disease);
        }
    }
}
