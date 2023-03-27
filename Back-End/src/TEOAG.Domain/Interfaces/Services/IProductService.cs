using System.Threading.Tasks;
using TEOAG.Domain.Entities;

namespace TEOAG.Domain.Interfaces.Repositories
{
    public interface IProductService
    {
        Task<Product> PostProduct(Product model);

        Task<Product> UpdateProduct(Product model);

        Task<bool> DeleteProduct(int productId);

        Task<bool> FinishProduct(Product model);

        Task<Product[]> GetAllProductsAsync();

        Task<Product> GetAllProductByIdAsync(int productId);
          
    }
}