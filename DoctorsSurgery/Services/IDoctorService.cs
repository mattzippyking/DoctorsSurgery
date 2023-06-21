using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Services
{
    public interface IDoctorService
    {

        public Task CreateDoctor(string doctorName);

        IDoctor GetByDoctorId(Guid doctorId);

        IDoctor GetByDoctorName(string doctorName);

        public Task DeleteDoctor(Guid doctorId);

        public IEnumerable<IDoctor> GetAll();
    }
}
