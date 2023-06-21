namespace DoctorsSurgery.Entities
{
    public interface ISlot
    {
        public Guid Id { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime StartDate { get; set; }
        public Decimal Cost { get; set; }

    }
}
