namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            hospital.Rooms.Add(new Room(101, 2));
            hospital.Rooms.Add(new Room(102, 1));

            Doctor doctor = new Doctor(
                "Ali", 40, 10282839,
                101, "Cardiology");

            hospital.Doctors.Add(doctor);

            Patient patient1 = new Patient(
                "Reza", 25, 23598584, 1001);

            Patient patient2 = new Patient(
                "Amir", 45, 0083727829, 1002);

            hospital.AdmitPatient(patient1);
            hospital.AdmitPatient(patient2);

            Console.WriteLine("\n--- Doctor Diagnosis ---");

            doctor.Diagnose(patient1, "Hypertension");

            Console.WriteLine("\n--- Patient Details ---");
            Console.WriteLine(patient1.GetDetails());

            Console.WriteLine("\n--- Discharge Patient ---");
            hospital.DischargePatient(1002);

            Console.WriteLine("\n--- Admit Another Patient ---");

            Patient patient3 = new Patient(
                "Nima", 28, 29938392, 1003);

            hospital.AdmitPatient(patient3);

            Console.WriteLine($"Patient {patient3.Name} (ID: {patient3.PatientID}) admitted successfully.");
        }
    }
}
