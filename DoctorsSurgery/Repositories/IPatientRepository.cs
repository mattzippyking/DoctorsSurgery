using DoctorsSurgery.Entities;

namespace DoctorsSurgery.Repositories
{
    public interface IPatientRepository
    {

        /// <summary>
        /// Add a patient to the patient database
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public Task Add(IPatient patient);

        /// <summary>
        /// Delete a patient from the patient database
        /// </summary>
        /// <param name="patient"></param>
        public Task Delete(IPatient patient);

        /// <summary>
        /// Check to see if a patient exists within the patient database with a particular name
        /// </summary>
        /// <param name="name">Name of the patient</param>
        /// <returns></returns>
        public Boolean Exists(String patientName);

        /// <summary>
        /// Check to see if a patient exists within the patient database with a particular Id 
        /// </summary>
        /// <param name="id">Guid based Id for the patient</param>
        /// <returns></returns>
        public Boolean Exists(Guid patientId);

        public IPatient GetById(Guid patientId);

        public IPatient GetByName(string patientName);

        public IEnumerable<IPatient> GetAll();


    }
}
