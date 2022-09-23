using BLL.Models;

namespace BLL.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task Create(Product model);

        Task Update(Product model);

        Task Delete(Product model);

        Task<Product> GetById(Product model);

        Task<Product> GetByName(Product model);

        Task<IEnumerable<Product>> GetAll();

        Task<IEnumerable<Product>> GetByCategory(Guid categoryId);
    }
}
