using System;
using System.Threading.Tasks;
using TEOAG.Domain.Entities;

namespace TEOAG.Domain.Interfaces.Repositories
{
    public interface IProductRepo : IGeneralRepo
    {
         Task<Product[]> GetAllAsync();

         
         Task<Product> GetByIdAsync(int id);

         Task<Product> GetByNameAsync(string productName);
          
    }
}