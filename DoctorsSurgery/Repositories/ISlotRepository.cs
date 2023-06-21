using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Repositories
{
    public interface ISlotRepository
    {

        public Task Add(ISlot slot);

        public Task Delete(ISlot slot);

        public Boolean Exists(Guid slotId);

        public ISlot GetById(Guid slotId);

        public IEnumerable<ISlot> GetAll();
    }
}
