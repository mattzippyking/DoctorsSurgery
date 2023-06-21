using DoctorsSurgery.Entities;
using DoctorsSurgery.Repositories;

namespace DoctorsSurgery.Services
{
    public class PatientService : IPatientService
    {

        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        { 
            _patientRepository= patientRepository;
        }

        public Task CreatePatient(string patientName)
        {
            var patient = new Patient { Name = patientName, Id = Guid.NewGuid() };
            _patientRepository.Add(patient);
            return Task.CompletedTask;
        }

        public Task DeletePatient(Guid patientId)
        {
            var patient = _patientRepository.GetById(patientId);
            _patientRepository.Delete(patient);
            return Task.CompletedTask;
        }

        public IPatient GetByPatientId(Guid patientId)
        {
            return _patientRepository.GetById(patientId);
        }

        public IPatient GetByPatientName(string patientName)
        {
            return _patientRepository.GetByName(patientName);
        }

        public IEnumerable<IPatient> GetAll()
        {
            return _patientRepository.GetAll(); 
        }

    }
}
