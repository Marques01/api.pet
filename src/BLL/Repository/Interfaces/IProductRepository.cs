using BLL.Models;

namespace BLL.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task CreateAsync(Product model);

        void Update(Product model);

        void Delete(Product model);

        Product GetById(Guid id);

        Task<IEnumerable<Product>> GetByName(string name);

        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
