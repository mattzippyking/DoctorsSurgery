namespace DoctorsSurgery.Entities
{
    public interface IPatient
    {
        string Name { get; set; }
        Guid Id { get; set; }
    }
}
