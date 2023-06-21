namespace DoctorsSurgery.Entities
{
    public interface IDoctor
    {
        /// <summary> Doctor's name </summary>
        string Name { get; set; }
        
        /// <summary> Unique identification number in Guid format </summary>
        Guid Id { get; set; }
    }
}
