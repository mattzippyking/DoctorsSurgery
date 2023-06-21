using DoctorsSurgery.Entities;
using DoctorsSurgery.Repositories;

namespace DoctorsSurgery.Services
{
    public class SlotService : ISlotService
    {
        private readonly ISlotRepository _slotRepository;

        public SlotService(ISlotRepository slotRepository)
        {
            _slotRepository = slotRepository;
        }

        public Task CreateSlot(Guid doctorId, DateTime startDate, decimal cost)
        {
            var slot = new Slot { DoctorId = doctorId, Id = Guid.NewGuid(), StartDate = startDate, Cost = cost };
            _slotRepository.Add(slot);
            return Task.CompletedTask;
        }

        public Task DeleteSlot(Guid slottId)
        {
            var slot = _slotRepository.GetById(slottId);
            _slotRepository.Delete(slot);
            return Task.CompletedTask;
        }

        public IEnumerable<ISlot> GetAll()
        {
            return _slotRepository.GetAll();
        }

        public ISlot GetBySlotId(Guid slotId)
        {
            return _slotRepository.GetById(slotId);
        }
    }
}
