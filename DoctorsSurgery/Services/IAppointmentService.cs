using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Services
{
    public interface IAppointmentService
    {

        public Task CreateAppointment(Guid patientId, Guid slotId);

        IAppointment GetByAppointmentId(Guid appointmentId);

        public Task DeleteAppointment(Guid appointmentId);

        public IEnumerable<IAppointment> GetAll();

    }
}
