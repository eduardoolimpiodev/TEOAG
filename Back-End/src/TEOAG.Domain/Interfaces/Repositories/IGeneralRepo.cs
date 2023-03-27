using System.Threading.Tasks;

namespace TEOAG.Domain.Interfaces.Repositories
{
    public interface IGeneralRepo
    {
         void Add<T>(T entity) where T : class;

         void Put<T>(T entity) where T : class;

         void DeleteAll<T>(T[] entity) where T : class;

         Task<bool> SaveChangeAsync();
    }
}