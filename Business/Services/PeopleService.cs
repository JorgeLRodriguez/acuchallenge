using Business.Contracts;
using Domain;

namespace Business.Services
{
    internal sealed class PeopleService : IPeopleService
    {
        public PeopleService() {
        }
        public void Delete(int ID)
        {
            try
            {
                Data.Factory.Factory.Current.PeopleRepository.Delete(ID);
                Data.Factory.Factory.Current.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        public List<People> GetAll()
        {
            List<People> listPeople = null;
            try
            {
                listPeople = Data.Factory.Factory.Current.PeopleRepository.Get().ToList();
            }
            catch
            {
                throw;
            }
            return listPeople ?? throw new Exception("There aren't data to show.");
        }
        public People GetByID(int ID)
        {
            People people = null;
            try
            {
                people = Data.Factory.Factory.Current.PeopleRepository.GetById(ID);
            }
            catch
            {
                throw;
            }
            return people ?? throw new Exception("There aren't data to show.");
       
        }
    }
}
