namespace DoctorsSurgery.Entities
{
    public class Doctor : IDoctor
    {
        public string Name { get ; set; }
        public Guid Id { get ; set; }
    }
}
