

using System.Threading.Tasks;
using TEOAG.Domain.Entities;
using TEOAG.Domain.Interfaces.Repositories;

namespace TEOAG.Data.Repositories
{
    public class GeneralRepo : IGeneralRepo
    {
        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAll<T>(T[] entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Put<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangeAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}