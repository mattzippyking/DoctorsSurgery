using DoctorsSurgery.Entities;
using DoctorsSurgery.Database;
using System.Reflection.Metadata;
using System.Xml.Linq;


namespace DoctorsSurgery.Repositories
{
    public class PatientRepository : IPatientRepository
    {

        private readonly SurgeryContext _db;

        public PatientRepository(SurgeryContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Return a list of all the patients from the Patient Database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IPatient> GetAll()
        {
            return _db.Patients.ToList();
        }

        public Task Add(IPatient patient)
        {
            _db.Patients.Add(patient);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public Task Delete(IPatient patient)
        {
            _db.Patients.Remove(patient);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public bool Exists(string patientName)
        {
            return _db.Patients.Any(u => u.Name == patientName);
        }

        public bool Exists(Guid patientId)
        {
            return _db.Patients.Any(u => u.Id == patientId);
        }

        public IPatient GetById(Guid patientId)
        {
            var patient = _db.Patients.First(u => u.Id == patientId);
            return patient;
        }

        public IPatient GetByName(string patientName)
        {
            var patient = _db.Patients.First(u => u.Name == patientName);
            return patient; 
        }
    }
}
