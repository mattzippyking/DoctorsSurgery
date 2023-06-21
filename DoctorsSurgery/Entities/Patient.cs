namespace DoctorsSurgery.Entities
{
    public class Patient : IPatient
    {
        public string Name { get ; set ; }
        public Guid Id { get ; set ; }
    }
}
