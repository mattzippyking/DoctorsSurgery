namespace DoctorsSurgery.Entities
{
    public interface IAppointment
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public Guid SlotId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
