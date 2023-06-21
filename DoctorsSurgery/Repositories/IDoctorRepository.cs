using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Repositories
{
    public interface IDoctorRepository
    {
        public Task Add(IDoctor doctor);

        public Task Delete(IDoctor doctor);

        public Boolean Exists(String doctorName);

        public Boolean Exists(Guid doctorId);

        public IDoctor GetById(Guid doctorId);

        public IDoctor GetByName(string doctorName);

        public IEnumerable<IDoctor> GetAll();
    }
}
