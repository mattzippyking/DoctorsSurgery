using DoctorsSurgery.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsSurgery.Controllers
{
    [Route("patients")]
    public class PatientController : Controller
    {

        private PatientService _patientService;

        public PatientController(PatientService patientService) 
        {
            _patientService = patientService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("post")]
        [HttpPost]
        public async Task<IActionResult> Post([FromHeader] string name)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();
                return BadRequest(errors);
            }
            await _patientService.CreatePatient(name);
            return Ok("Patient created...");
        }

        [Route("get")]
        [HttpGet]
        public async Task<IActionResult> Get([FromHeader] string? patientName)
        {
            
           if (string.IsNullOrEmpty(patientName))
                {
                    return Ok(_patientService.GetAll());
                }

            var product = _patientService.GetByPatientName(patientName); 

                if (product == null)
                    return BadRequest("Patient not found!");

                return Ok(product);
        }
            
    }

}
