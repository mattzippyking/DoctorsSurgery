using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Services
{
    public interface IPatientService
    {

        public Task CreatePatient(string patientName);

        IPatient GetByPatientId(Guid patientId);

        IPatient GetByPatientName(string patientName);

        public Task DeletePatient(Guid patientId);

        public IEnumerable<IPatient> GetAll();

    }
}
