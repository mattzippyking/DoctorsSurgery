using DoctorsSurgery.Database;
using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly SurgeryContext _db;
        
        public AppointmentRepository(SurgeryContext db)
        {
            _db = db;
        }

        public Task Add(IAppointment appointment)
        {
            _db.Appointments.Add(appointment);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public Task Delete(IAppointment appointment)
        {
            _db.Appointments.Remove(appointment);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public bool Exists(Guid appointmentId)
        {
            return _db.Appointments.Any(u => u.Id == appointmentId);
        }

        public IEnumerable<IAppointment> GetAll()
        {
            return _db.Appointments.ToList();
        }

        public IAppointment GetById(Guid appointmentId)
        {
            return _db.Appointments.First(u => u.Id == appointmentId);
        }
    }
}
