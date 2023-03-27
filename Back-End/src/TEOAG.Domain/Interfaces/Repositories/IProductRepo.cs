using System.Threading.Tasks;
using TEOAG.Domain.Entities;

namespace TEOAG.Domain.Interfaces.Repositories
{
    public interface IProductRepo
    {
         Task<Product[]> GetAllAsync();
         
         Task<Product> GetByIdAsync();

         Task<Product> GetByNameAsync();
          
    }
}