using BLL.Models;
using BLL.Repository.Interfaces;
using DAL.Context;
using System.Reflection.Metadata;

namespace DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Product model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetByCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(Product model)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByName(Product model)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product model)
        {
            throw new NotImplementedException();
        }
    }
}
