namespace DoctorsSurgery.Entities
{
    public interface IDoctor
    {
        string Name { get; set; }
        Guid Id { get; set; }
    }
}
