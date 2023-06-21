using DoctorsSurgery.Entities;
using DoctorsSurgery.Repositories;

namespace DoctorsSurgery.Services
{
    public class DoctorService : IDoctorService
    {

        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public Task CreateDoctor(string doctorName)
        {
            var doctor = new Doctor { Name = doctorName, Id = Guid.NewGuid() };
            _doctorRepository.Add(doctor);
            return Task.CompletedTask;
        }

        public Task DeleteDoctor(Guid doctorId)
        {
            var doctor = _doctorRepository.GetById(doctorId);
            _doctorRepository.Delete(doctor);
            return Task.CompletedTask;
        }

        public IEnumerable<IDoctor> GetAll()
        {
            return _doctorRepository.GetAll();
        }

        public IDoctor GetByDoctorId(Guid doctorId)
        {
            return _doctorRepository.GetById(doctorId);
        }

        public IDoctor GetByDoctorName(string doctorName)
        {
            return _doctorRepository.GetByName(doctorName);
        }
    }
}
