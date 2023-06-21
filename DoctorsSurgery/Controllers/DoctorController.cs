using DoctorsSurgery.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsSurgery.Controllers
{
    [Route("doctors")]
    public class DoctorController : Controller
    {
        private DoctorService _doctorService;

        public DoctorController(DoctorService doctorService)
        {
            _doctorService = doctorService;
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
            await _doctorService.CreateDoctor(name);
            return Ok("Doctor created...");
        }

        [Route("/get")]
        [HttpGet]
        public async Task<IActionResult> Get([FromHeader] string? doctorName)
        {

            if (string.IsNullOrEmpty(doctorName))
            {
                return Ok(_doctorService.GetAll());
            }

            var product = _doctorService.GetByDoctorName(doctorName);

            if (product == null)
                return BadRequest("Doctor not found!");

            return Ok(product);
        }

    }
}

