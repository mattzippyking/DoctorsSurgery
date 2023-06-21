using DoctorsSurgery.Database;
using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {

        private readonly SurgeryContext _db;

        public DoctorRepository(SurgeryContext db)
        {
            _db = db;
        }

        public Task Add(IDoctor doctor)
        {
            _db.Doctors.Add(doctor);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public Task Delete(IDoctor doctor)
        {
            _db.Doctors.Remove(doctor);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public bool Exists(string doctorName)
        {
            return _db.Doctors.Any(u => u.Name == doctorName);
        }

        public bool Exists(Guid doctorId)
        {
            return _db.Doctors.Any(u => u.Id == doctorId);
        }

        public IEnumerable<IDoctor> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDoctor GetById(Guid doctorId)
        {
            var doctor = _db.Doctors.First(u => u.Id == doctorId);
            return doctor;
        }

        public IDoctor GetByName(string doctorName)
        {
            var doctor = _db.Doctors.First(u => u.Name == doctorName);
            return doctor;
        }
    }
}
