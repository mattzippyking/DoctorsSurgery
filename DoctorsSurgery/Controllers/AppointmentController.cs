using DoctorsSurgery.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsSurgery.Controllers
{
    public class AppointmentController : Controller
    {
        private AppointmentService _appointmentService;

        public AppointmentController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("post")]
        [HttpPost]
        public async Task<IActionResult> Post([FromHeader] Guid patientId, Guid slotId)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();
                return BadRequest(errors);
            }
            await _appointmentService.CreateAppointment(patientId, slotId);
            return Ok("Appointment created...");
        }

        [Route("get")]
        [HttpGet]
        public async Task<IActionResult> Get([FromHeader] Guid appointmentId)
        {

            var slot = _appointmentService.GetByAppointmentId(appointmentId);

            if (slot == null)
                return BadRequest("Appointment not found!");

            return Ok(slot);
        }
    }
}
