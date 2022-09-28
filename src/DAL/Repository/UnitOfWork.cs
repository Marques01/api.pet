using BLL.Repository.Interfaces;
using DAL.Context;
using System.Reflection.Metadata;

namespace DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            ProductRepository = new ProductRepository(_context);
        }

        public IProductRepository ProductRepository { get; }
    }
}
