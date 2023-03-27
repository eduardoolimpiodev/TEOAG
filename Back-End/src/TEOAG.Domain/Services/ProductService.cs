using System;
using System.Threading.Tasks;
using TEOAG.Domain.Entities;
using TEOAG.Domain.Interfaces.Repositories;



namespace TEOAG.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly IGeneralRepo _generalRepo;
        public ProductService(IProductRepo productRepo, IGeneralRepo generalRepo)
        {
            _productRepo = productRepo;
            _generalRepo = generalRepo;
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FinishProduct(Product model)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAllProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product[]> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> PostProduct(Product model)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(Product model)
        {
            throw new NotImplementedException();
        }
    }
}