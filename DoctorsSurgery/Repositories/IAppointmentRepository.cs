using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Repositories
{
    public interface IAppointmentRepository
    {
        public Task Add(IAppointment appointment);

        public Task Delete(IAppointment appointment);

        public Boolean Exists(Guid appointmentId);

        public IAppointment GetById(Guid appointmentId);

        public IEnumerable<IAppointment> GetAll();
    }
}
