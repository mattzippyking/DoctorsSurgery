using DoctorsSurgery.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsSurgery.Controllers
{
    [Route("slots")]
    public class SlotController : Controller
    {

        private SlotService _slotService;

        public SlotController(SlotService slotService)
        {
            _slotService = slotService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [Route("post")]
        [HttpPost]
        public async Task<IActionResult> Post([FromHeader] Guid doctorId, DateTime startDate, Decimal cost)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                    .SelectMany(value => value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();
                return BadRequest(errors);
            }
            await _slotService.CreateSlot(doctorId, startDate, cost);
            return Ok("Slot created...");
        }

        [Route("get")]
        [HttpGet]
        public async Task<IActionResult> Get([FromHeader] Guid slotId)
        {

            var slot = _slotService.GetBySlotId(slotId);

            if (slot == null)
                return BadRequest("Slot not found!");

            return Ok(slot);
        }
    }
}
