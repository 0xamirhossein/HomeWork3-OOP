using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; }

        public Room(int roomnumber, int capacity)
        {
            RoomNumber = roomnumber;
            Capacity = capacity;

            Patients = new List<Patient>();
        }

        public void AssignPatient(Patient patient)
        {
            if (Patients.Count >= Capacity)
            {
                throw new RoomFullException("room is full ");
            }
            else
            {
                Patients.Add(patient);
            }
        }
        public bool RemovePatient(int patientID)
        {
            foreach (Patient patient in Patients)
            {
                if (patient.PatientID == patientID)
                {
                    Patients.Remove(patient);
                    return true;
                }
            }
            return false;

        }
    }
}
