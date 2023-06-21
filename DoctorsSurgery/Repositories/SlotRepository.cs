using DoctorsSurgery.Database;
using DoctorsSurgery.Entities;
using System.Numerics;

namespace DoctorsSurgery.Repositories
{
    public class SlotRepository : ISlotRepository
    {
        private readonly SurgeryContext _db;

        public SlotRepository(SurgeryContext db)
        {
            _db = db;
        }

        public Task Add(ISlot slot)
        {
            _db.Slots.Add(slot);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public Task Delete(ISlot slot)
        {
            _db.Slots.Remove(slot);
            _db.SaveChanges();
            return Task.CompletedTask;
        }

        public bool Exists(Guid slotId)
        {
            return _db.Slots.Any(u => u.Id == slotId);
        }

        public IEnumerable<ISlot> GetAll()
        {
            return _db.Slots.ToList();
        }

        public ISlot GetById(Guid slotId)
        {
            return _db.Slots.First(u => u.Id == slotId);
        }
    }
}
