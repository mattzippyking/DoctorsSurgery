namespace DoctorsSurgery.Entities
{
    public class Appointment : IAppointment
    {
        /// <summary> Unique identification number for the appointment in Guid format </summary>
        public Guid Id { get; set; }
        
        /// <summary> Reference to the identification number for the patient in Guid format </summary>
        public Guid PatientId { get; set; }
        
        /// <summary> Reference to the identification number for the slot in Guid format </summary>
        public Guid SlotId { get; set; }
        
        /// <summary> Time of when the appointment was created </summary> 
        public DateTime CreatedDate { get; set; }
    }
}
