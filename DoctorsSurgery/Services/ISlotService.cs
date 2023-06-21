using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Services
{
    public interface ISlotService
    {

        public Task CreateSlot(Guid doctorId, DateTime startDate, Decimal cost);

        ISlot GetBySlotId(Guid slotId);

        public Task DeleteSlot(Guid slottId);

        public IEnumerable<ISlot> GetAll();
    }
}
