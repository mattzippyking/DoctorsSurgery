using DoctorsSurgery.Entities;
using DoctorsSurgery.Repositories;
using Microsoft.Extensions.Hosting;

namespace DoctorsSurgery.Services
{
    public class AppointmentService : IAppointmentService
    {

        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public Task CreateAppointment(Guid patientId, Guid slotId)
        {
            var appointment = new Appointment { PatientId = patientId, SlotId = slotId, Id = Guid.NewGuid(), CreatedDate = DateTime.Now };
            _appointmentRepository.Add(appointment);
            return Task.CompletedTask;
        }

        public Task DeleteAppointment(Guid appointmentId)
        {
            var appointment = _appointmentRepository.GetById(appointmentId);
            _appointmentRepository.Delete(appointment);
            return Task.CompletedTask;
        }

        public IEnumerable<IAppointment> GetAll()
        {
            return _appointmentRepository.GetAll();
        }

        public IAppointment GetByAppointmentId(Guid appointmentId)
        {
            return _appointmentRepository.GetById(appointmentId);
        }
    }
}
