using BLL.Models;
using BLL.Repository.Interfaces;

namespace DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
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
