namespace DoctorsSurgery.Entities
{
    public class Slot : ISlot
    {
        public Guid Id { get ; set ; }
        public Guid DoctorId { get ; set ; }
        public DateTime StartDate { get ; set ; }
        public decimal Cost { get ; set ; }
    }
}
