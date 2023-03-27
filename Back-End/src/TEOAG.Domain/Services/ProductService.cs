using System;
using System.Threading.Tasks;
using TEOAG.Domain.Entities;
using TEOAG.Domain.Interfaces.Repositories;



namespace TEOAG.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        
        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<Product> PostProduct(Product model)
        {
            if( await _productRepo.GetByNameAsync(model.ProductName) != null)
            throw new Exception("Já existe um Produto com esse nome.");

            // if( await _productRepo.Put(model.ExpirationDate >= model.ManufacturingDate))
            // throw new Exception("Produto com Data de Fabricação maior ou igual a Data de validade");

            if (await _productRepo.GetByIdAsync(model.Id) == null)
            {
                _productRepo.Add(model);
                if(await _productRepo.SaveChangeAsync())
                return model;
            }
            return null;
        }

        public async Task<Product> UpdateProduct(Product model)
        {
            if(model.ManufacturingDate >= model.ExpirationDate)
            throw new Exception("Não se pode alterar o produto com a data errada");

            if (await _productRepo.GetByIdAsync(model.Id) == null)
            {
                _productRepo.Put(model);
                if(await _productRepo.SaveChangeAsync())
                return model;
            }
            return null;
        }

        public async Task<bool> FinishProduct(Product model)
        {
            if(model != null)
            {
            model.Finish();
            _productRepo.Put<Product>(model);
            return await _productRepo.SaveChangeAsync();
            }
            return false;
           
        }


        public async Task<bool> DeleteProduct(int productId)
        {
            var product = await _productRepo.GetByIdAsync(productId);
            if(product == null) throw new Exception("Produto que tentou deletar não existe");

            _productRepo.Delete(product);
            return await _productRepo.SaveChangeAsync();

        }

        public async Task<Product> GetAllProductByIdAsync(int productId)
        {
            try
            {
                 var product = await _productRepo.GetByIdAsync(productId);
                 if(product == null) return null;

                 return product;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product[]> GetAllProductsAsync()
        {
            try
            {
                 var products = await _productRepo.GetAllAsync();
                 if(products == null) return null;

                 return products;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

    }
}