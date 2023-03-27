

using System.Threading.Tasks;
using TEOAG.Domain.Entities;
using TEOAG.Domain.Interfaces.Repositories;

namespace TEOAG.Data.Repositories
{
    public class ProductRepo : GeneralRepo, IProductRepo
    {       

        public Task<Product> GetByNameAsync(string productName)
        {
            throw new System.NotImplementedException();
        } 
        public Task<Product[]> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }     
    }
}