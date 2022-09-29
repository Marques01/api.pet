using BLL.Models;
using BLL.Repository.Interfaces;
using DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Product model)
        {
            try
            {
                await _context.Products.AddAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possivel cadastrar o produto\n{ex.Message}");
            }
        }

        public void Delete(Product model)
        {
            try
            {
                _context.Products.Remove(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possivel deletar o produto\n{ex.Message}");
            }
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            try
            {
                var products = await _context.Products!.AsNoTracking().ToListAsync();

                if (products != null)
                    return products;

                return Enumerable.Empty<Product>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possivel obter a lista de produtos\n{ex.Message}");
            }
        }

        public Product GetById(Guid id)
        {
            try
            {
                var product = _context.Products
                    .AsNoTracking()
                    .FirstOrDefault(x => x.ProductId.Equals(id));

                if (product != null)
                    return product;

                return new Product();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possivel buscar o produto pelo id\n{ex.Message}");
            }
        }

        public async Task<IEnumerable<Product>> GetByName(string name)
        {
            try
            {
                var products = await _context.Products
                    .AsNoTracking()
                    .Where(x => x.Name.Contains(name))
                    .ToListAsync();

                if (products != null)
                    return products;

                return Enumerable.Empty<Product>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possivel obter os produtos pelo nome\n{ex.Message}");
            }
        }

        public void Update(Product model)
        {
            try
            {
                _context.Products.Update(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possivel atualizar a o produto\n{ex.Message}");
            }
        }
    }
}
