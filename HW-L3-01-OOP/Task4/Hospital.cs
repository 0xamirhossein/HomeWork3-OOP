using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    internal class Hospital
    {
        public List<Doctor> Doctors { get; set; }
        public List<Room> Rooms { get; set; }

        public Hospital()
        {
            Doctors = new List<Doctor>();
            Rooms = new List<Room>();
        }

        public void AdmitPatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                if (room.Patients.Count < room.Capacity)
                {

                    room.AssignPatient(patient);
                    return;

                }
                
            }
            throw new RoomFullException("room is full ");

        }

        public void DischargePatient(int patientID)
        {
            foreach (Room room in Rooms)
            {
                if (room.RemovePatient(patientID))
                {
                    Console.WriteLine(
                        $"Patient {patientID} discharged successfully.");
                    return;
                }
            }

            Console.WriteLine(
                $"Patient {patientID} was not found in the hospital.");
        }
    }
}