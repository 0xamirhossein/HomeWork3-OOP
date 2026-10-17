using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    internal class Doctor : Person
    {
        public int DoctorID { get; set; }
        public string Specialization { get; set; }


        public Doctor(string name, int age, long nationalID,int doctorID, string specialization) : base(name, age, nationalID)
        {
            DoctorID = doctorID;
            Specialization = specialization;
        }

        public void Diagnose(Patient patient, string diagnosis)
        {
            patient.AddToMedicalHistory(diagnosis);
            Console.WriteLine($"Doctor {Name} diagnosed {patient.Name} with: {diagnosis}");
        }
    }
}
