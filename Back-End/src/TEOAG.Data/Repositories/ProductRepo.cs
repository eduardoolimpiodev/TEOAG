using System.Linq;
using System.Threading.Tasks;
using TEOAG.Data.Context;
using TEOAG.Domain.Entities;
using TEOAG.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TEOAG.Data.Repositories
{
    public class ProductRepo : GeneralRepo, IProductRepo
    {
        private readonly DataContext _context;
        public ProductRepo(DataContext context) : base(context)
        {
            _context = context;

        }

        public async Task<Product> GetByIdAsync(int id)
        {
            IQueryable<Product> query = _context.Products;

            query = query.AsNoTracking()
                .OrderBy(pr => pr.Id)
                .Where( pr => pr.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Product> GetByNameAsync(string productName)
        {
            IQueryable<Product> query = _context.Products;

            query = query.AsNoTracking()
                .OrderBy(pr => pr.Id);
               

            return await query.FirstOrDefaultAsync(pr => pr.ProductName == productName);
        }
         public async Task<Product[]> GetAllAsync()
        {
            IQueryable<Product> query = _context.Products;

            query = query.AsNoTracking()
                .OrderBy(pr => pr.Id);

            return await query.ToArrayAsync();
        }
    }
}
       
